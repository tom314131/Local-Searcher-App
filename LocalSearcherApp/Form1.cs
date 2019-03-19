using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Threading;

namespace LocalSearcherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Hide();
        }

        private void pasteBtn_Click(object sender, EventArgs e)
        {
            path.Text = Clipboard.GetText();
        }

        private void openDialogBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            path.Text = fbd.SelectedPath;
        }

        private void search_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (Directory.Exists(path.Text))
            {
                DirectoryInfo di = new DirectoryInfo(path.Text);
                FileInfo[] files = di.GetFiles();
                DirectoryInfo[] dic = di.GetDirectories();
                int count = 0;
                foreach (FileInfo file in files)
                {
                    if (file.Name.IndexOf(fileTextBox.Text) >= 0)
                    {
                        string[] row = new string[] { file.Name,file.DirectoryName };
                        dataGridView1.Rows.Add(row);
                        count++;
                    }
                }
                if(dic!=null)
                {
                    AddFilesFromDirectory(dic);
                }
                dataGridView1.Show();
            }
            else
            {
                MessageBox.Show("Path is not valid");
            }
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            Process.Start(dataGridView1.CurrentRow.Cells[1].Value.ToString() + "\\"+
                dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void directoryBtn_Click(object sender, EventArgs e)
        {
            Process.Start(dataGridView1.CurrentRow.Cells[1].Value.ToString());
        }
        private void AddFilesFromDirectory(DirectoryInfo[] directoryInfos)
        {
            foreach (DirectoryInfo di in directoryInfos)
            {
                FileInfo[] files = di.GetFiles();
                DirectoryInfo[] dic = di.GetDirectories();
                int count = 0;
                foreach (FileInfo file in files)
                {
                    if (file.Name.IndexOf(fileTextBox.Text) >= 0)
                    {
                        string[] row = new string[] { file.Name, file.DirectoryName };
                        dataGridView1.Rows.Add(row);
                        count++;
                    }
                }
                if(dic!=null)
                {
                    AddFilesFromDirectory(dic);
                }
            }
        }

        private void changeNameBtn_Click(object sender, EventArgs e)
        {
            string path = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string fileName = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string input = Microsoft.VisualBasic.Interaction.InputBox("Please enter new name",
                    "New name", fileName);
            if (input != "")
            {
                System.IO.File.Move(path + "\\" + fileName, path + "\\" + input);
                dataGridView1.CurrentRow.Cells[0].Value = input;
            }
        }
    }
}
