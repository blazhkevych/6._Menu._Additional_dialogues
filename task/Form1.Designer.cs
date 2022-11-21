namespace task
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdddddddddddasdasdasdasdasdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Filtration_checkBox1 = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.saveToolStripMenuItem.Text = "&Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem,
            this.toolStripSeparator1,
            this.booksToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAuthorToolStripMenuItem,
            this.removeAuthorToolStripMenuItem,
            this.editAuthorToolStripMenuItem});
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.authorToolStripMenuItem.Text = "Author...";
            // 
            // addAuthorToolStripMenuItem
            // 
            this.addAuthorToolStripMenuItem.Name = "addAuthorToolStripMenuItem";
            this.addAuthorToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.addAuthorToolStripMenuItem.Text = "Add author";
            this.addAuthorToolStripMenuItem.Click += new System.EventHandler(this.addAuthorToolStripMenuItem_Click);
            // 
            // removeAuthorToolStripMenuItem
            // 
            this.removeAuthorToolStripMenuItem.Name = "removeAuthorToolStripMenuItem";
            this.removeAuthorToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.removeAuthorToolStripMenuItem.Text = "Remove author";
            this.removeAuthorToolStripMenuItem.Click += new System.EventHandler(this.removeAuthorToolStripMenuItem_Click);
            // 
            // editAuthorToolStripMenuItem
            // 
            this.editAuthorToolStripMenuItem.Name = "editAuthorToolStripMenuItem";
            this.editAuthorToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.editAuthorToolStripMenuItem.Text = "Edit author";
            this.editAuthorToolStripMenuItem.Click += new System.EventHandler(this.editAuthorToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem,
            this.removeBookToolStripMenuItem,
            this.asdddddddddddasdasdasdasdasdToolStripMenuItem});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.booksToolStripMenuItem.Text = "Book...";
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.addBookToolStripMenuItem.Text = "Add book";
            // 
            // removeBookToolStripMenuItem
            // 
            this.removeBookToolStripMenuItem.Name = "removeBookToolStripMenuItem";
            this.removeBookToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.removeBookToolStripMenuItem.Text = "Remove book";
            // 
            // asdddddddddddasdasdasdasdasdToolStripMenuItem
            // 
            this.asdddddddddddasdasdasdasdasdToolStripMenuItem.Name = "asdddddddddddasdasdasdasdasdToolStripMenuItem";
            this.asdddddddddddasdasdasdasdasdToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.asdddddddddddasdasdasdasdasdToolStripMenuItem.Text = "Edit book";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Library.txt";
            this.openFileDialog1.Filter = "TXT files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Library.txt";
            this.saveFileDialog1.Filter = "TXT files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // Filtration_checkBox1
            // 
            this.Filtration_checkBox1.AutoSize = true;
            this.Filtration_checkBox1.Location = new System.Drawing.Point(698, 421);
            this.Filtration_checkBox1.Name = "Filtration_checkBox1";
            this.Filtration_checkBox1.Size = new System.Drawing.Size(90, 24);
            this.Filtration_checkBox1.TabIndex = 1;
            this.Filtration_checkBox1.Text = "Filtration";
            this.Filtration_checkBox1.UseVisualStyleBackColor = true;
            this.Filtration_checkBox1.Click += new System.EventHandler(this.Filtration_checkBox1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(0, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(800, 344);
            this.listBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(800, 28);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Filtration_checkBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authors and books";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private CheckBox Filtration_checkBox1;
        private ListBox listBox1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem authorToolStripMenuItem;
        private ToolStripMenuItem addAuthorToolStripMenuItem;
        private ToolStripMenuItem removeAuthorToolStripMenuItem;
        private ToolStripMenuItem editAuthorToolStripMenuItem;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem addBookToolStripMenuItem;
        private ToolStripMenuItem removeBookToolStripMenuItem;
        private ToolStripMenuItem asdddddddddddasdasdasdasdasdToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ComboBox comboBox1;
    }
}