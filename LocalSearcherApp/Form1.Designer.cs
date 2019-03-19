namespace LocalSearcherApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openDialogBtn = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.TextBox();
            this.directoryBtn = new System.Windows.Forms.Button();
            this.changeNameBtn = new System.Windows.Forms.Button();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.pasteBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificDirectory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // openDialogBtn
            // 
            this.openDialogBtn.Location = new System.Drawing.Point(637, 16);
            this.openDialogBtn.Name = "openDialogBtn";
            this.openDialogBtn.Size = new System.Drawing.Size(135, 28);
            this.openDialogBtn.TabIndex = 0;
            this.openDialogBtn.Text = "Choose Folder";
            this.openDialogBtn.UseVisualStyleBackColor = true;
            this.openDialogBtn.Click += new System.EventHandler(this.openDialogBtn_Click);
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(23, 19);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(585, 22);
            this.path.TabIndex = 1;
            // 
            // directoryBtn
            // 
            this.directoryBtn.Location = new System.Drawing.Point(379, 439);
            this.directoryBtn.Name = "directoryBtn";
            this.directoryBtn.Size = new System.Drawing.Size(165, 72);
            this.directoryBtn.TabIndex = 3;
            this.directoryBtn.Text = "Open Directory";
            this.directoryBtn.UseVisualStyleBackColor = true;
            this.directoryBtn.Click += new System.EventHandler(this.directoryBtn_Click);
            // 
            // changeNameBtn
            // 
            this.changeNameBtn.Location = new System.Drawing.Point(777, 439);
            this.changeNameBtn.Name = "changeNameBtn";
            this.changeNameBtn.Size = new System.Drawing.Size(165, 72);
            this.changeNameBtn.TabIndex = 4;
            this.changeNameBtn.Text = "Change Name";
            this.changeNameBtn.UseVisualStyleBackColor = true;
            this.changeNameBtn.Click += new System.EventHandler(this.changeNameBtn_Click);
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(23, 439);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(165, 72);
            this.openFileBtn.TabIndex = 5;
            this.openFileBtn.Text = "Open File";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // pasteBtn
            // 
            this.pasteBtn.Location = new System.Drawing.Point(789, 16);
            this.pasteBtn.Name = "pasteBtn";
            this.pasteBtn.Size = new System.Drawing.Size(135, 28);
            this.pasteBtn.TabIndex = 6;
            this.pasteBtn.Text = "Past link";
            this.pasteBtn.UseVisualStyleBackColor = true;
            this.pasteBtn.Click += new System.EventHandler(this.pasteBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileName,
            this.specificDirectory});
            this.dataGridView1.Location = new System.Drawing.Point(23, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(929, 320);
            this.dataGridView1.TabIndex = 7;
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(218, 63);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(225, 22);
            this.fileTextBox.TabIndex = 8;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(469, 57);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(139, 28);
            this.search.TabIndex = 9;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fileName
            // 
            this.fileName.HeaderText = "File Name";
            this.fileName.Name = "fileName";
            this.fileName.ReadOnly = true;
            this.fileName.Width = 400;
            // 
            // specificDirectory
            // 
            this.specificDirectory.HeaderText = "Specific Directory";
            this.specificDirectory.Name = "specificDirectory";
            this.specificDirectory.ReadOnly = true;
            this.specificDirectory.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter File Name : (Optionnal)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pasteBtn);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.changeNameBtn);
            this.Controls.Add(this.directoryBtn);
            this.Controls.Add(this.path);
            this.Controls.Add(this.openDialogBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(983, 597);
            this.MinimumSize = new System.Drawing.Size(983, 597);
            this.Name = "Form1";
            this.Text = "Local Searcher App";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openDialogBtn;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Button directoryBtn;
        private System.Windows.Forms.Button changeNameBtn;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.Button pasteBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Button search;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn specificDirectory;
        private System.Windows.Forms.Label label1;
    }
}

