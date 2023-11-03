namespace ImageViewerAndMangementTool
{
    partial class MainForm
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
            menuStrip_Main = new MenuStrip();
            文件FToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem_OpenPath = new ToolStripMenuItem();
            toolStripMenuItem_ClosePath = new ToolStripMenuItem();
            toolStripMenuItem_RefreshList = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItem_Exit = new ToolStripMenuItem();
            帮助HToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem_Version = new ToolStripMenuItem();
            toolStripMenuItem_About = new ToolStripMenuItem();
            splitContainer_Main = new SplitContainer();
            dataGridView_Files = new DataGridView();
            Mark = new DataGridViewCheckBoxColumn();
            Extension = new DataGridViewTextBoxColumn();
            FileName = new DataGridViewTextBoxColumn();
            Path = new DataGridViewTextBoxColumn();
            splitContainer_ImageMangement = new SplitContainer();
            tableLayoutPanel_ImageViewer = new TableLayoutPanel();
            pictureBox_Main = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            button_Next = new Button();
            button_MarkAndNext = new Button();
            button_Previous = new Button();
            button_Mark = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button_DeleteMark = new Button();
            button_DeleteUnmark = new Button();
            panel1 = new Panel();
            button_MoveMark = new Button();
            button_MoveUnmark = new Button();
            panel3 = new Panel();
            button_CopyMark = new Button();
            button_CopyUnmark = new Button();
            panel2 = new Panel();
            progressBar = new ProgressBar();
            button_ProgressText = new Button();
            menuStrip_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer_Main).BeginInit();
            splitContainer_Main.Panel1.SuspendLayout();
            splitContainer_Main.Panel2.SuspendLayout();
            splitContainer_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Files).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer_ImageMangement).BeginInit();
            splitContainer_ImageMangement.Panel1.SuspendLayout();
            splitContainer_ImageMangement.Panel2.SuspendLayout();
            splitContainer_ImageMangement.SuspendLayout();
            tableLayoutPanel_ImageViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Main).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip_Main
            // 
            menuStrip_Main.Items.AddRange(new ToolStripItem[] { 文件FToolStripMenuItem, 帮助HToolStripMenuItem });
            menuStrip_Main.Location = new Point(0, 0);
            menuStrip_Main.Name = "menuStrip_Main";
            menuStrip_Main.Size = new Size(1149, 25);
            menuStrip_Main.TabIndex = 1;
            menuStrip_Main.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            文件FToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem_OpenPath, toolStripMenuItem_ClosePath, toolStripMenuItem_RefreshList, toolStripSeparator1, toolStripMenuItem_Exit });
            文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            文件FToolStripMenuItem.Size = new Size(58, 21);
            文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // toolStripMenuItem_OpenPath
            // 
            toolStripMenuItem_OpenPath.Name = "toolStripMenuItem_OpenPath";
            toolStripMenuItem_OpenPath.Size = new Size(142, 22);
            toolStripMenuItem_OpenPath.Text = "打开目录(&O)";
            toolStripMenuItem_OpenPath.Click += toolStripMenuItem_OpenPath_Click;
            // 
            // toolStripMenuItem_ClosePath
            // 
            toolStripMenuItem_ClosePath.Name = "toolStripMenuItem_ClosePath";
            toolStripMenuItem_ClosePath.Size = new Size(142, 22);
            toolStripMenuItem_ClosePath.Text = "关闭目录(&C)";
            // 
            // toolStripMenuItem_RefreshList
            // 
            toolStripMenuItem_RefreshList.Name = "toolStripMenuItem_RefreshList";
            toolStripMenuItem_RefreshList.Size = new Size(142, 22);
            toolStripMenuItem_RefreshList.Text = "刷新列表(&R)";
            toolStripMenuItem_RefreshList.Click += toolStripMenuItem_RefreshList_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(139, 6);
            // 
            // toolStripMenuItem_Exit
            // 
            toolStripMenuItem_Exit.Name = "toolStripMenuItem_Exit";
            toolStripMenuItem_Exit.Size = new Size(142, 22);
            toolStripMenuItem_Exit.Text = "退出(&E)";
            // 
            // 帮助HToolStripMenuItem
            // 
            帮助HToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem_Version, toolStripMenuItem_About });
            帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            帮助HToolStripMenuItem.Size = new Size(61, 21);
            帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // toolStripMenuItem_Version
            // 
            toolStripMenuItem_Version.Enabled = false;
            toolStripMenuItem_Version.Name = "toolStripMenuItem_Version";
            toolStripMenuItem_Version.Size = new Size(167, 22);
            toolStripMenuItem_Version.Text = "当前版本(V1.0.0)";
            // 
            // toolStripMenuItem_About
            // 
            toolStripMenuItem_About.Name = "toolStripMenuItem_About";
            toolStripMenuItem_About.Size = new Size(167, 22);
            toolStripMenuItem_About.Text = "关于(&A)";
            toolStripMenuItem_About.Click += toolStripMenuItem_About_Click;
            // 
            // splitContainer_Main
            // 
            splitContainer_Main.Dock = DockStyle.Fill;
            splitContainer_Main.Location = new Point(0, 25);
            splitContainer_Main.Name = "splitContainer_Main";
            // 
            // splitContainer_Main.Panel1
            // 
            splitContainer_Main.Panel1.Controls.Add(dataGridView_Files);
            // 
            // splitContainer_Main.Panel2
            // 
            splitContainer_Main.Panel2.Controls.Add(splitContainer_ImageMangement);
            splitContainer_Main.Size = new Size(1149, 609);
            splitContainer_Main.SplitterDistance = 312;
            splitContainer_Main.TabIndex = 2;
            // 
            // dataGridView_Files
            // 
            dataGridView_Files.AllowUserToAddRows = false;
            dataGridView_Files.AllowUserToDeleteRows = false;
            dataGridView_Files.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Files.Columns.AddRange(new DataGridViewColumn[] { Mark, Extension, FileName, Path });
            dataGridView_Files.Dock = DockStyle.Fill;
            dataGridView_Files.Location = new Point(0, 0);
            dataGridView_Files.MultiSelect = false;
            dataGridView_Files.Name = "dataGridView_Files";
            dataGridView_Files.ReadOnly = true;
            dataGridView_Files.RowTemplate.Height = 25;
            dataGridView_Files.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Files.Size = new Size(312, 609);
            dataGridView_Files.TabIndex = 0;
            dataGridView_Files.SelectionChanged += dataGridView_Files_SelectionChanged;
            dataGridView_Files.KeyDown += dataGridView_Files_KeyDown;
            dataGridView_Files.KeyPress += dataGridView_Files_KeyPress;
            dataGridView_Files.KeyUp += dataGridView_Files_KeyUp;
            // 
            // Mark
            // 
            Mark.DataPropertyName = "Mark";
            Mark.HeaderText = "标记";
            Mark.Name = "Mark";
            Mark.ReadOnly = true;
            Mark.Width = 60;
            // 
            // Extension
            // 
            Extension.DataPropertyName = "Extension";
            Extension.HeaderText = "文件扩展";
            Extension.Name = "Extension";
            Extension.ReadOnly = true;
            Extension.Resizable = DataGridViewTriState.True;
            Extension.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // FileName
            // 
            FileName.DataPropertyName = "FileName";
            FileName.HeaderText = "文件名";
            FileName.Name = "FileName";
            FileName.ReadOnly = true;
            FileName.Resizable = DataGridViewTriState.True;
            FileName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Path
            // 
            Path.DataPropertyName = "Path";
            Path.HeaderText = "文件路径";
            Path.Name = "Path";
            Path.ReadOnly = true;
            Path.Resizable = DataGridViewTriState.True;
            Path.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // splitContainer_ImageMangement
            // 
            splitContainer_ImageMangement.Dock = DockStyle.Fill;
            splitContainer_ImageMangement.Location = new Point(0, 0);
            splitContainer_ImageMangement.Name = "splitContainer_ImageMangement";
            // 
            // splitContainer_ImageMangement.Panel1
            // 
            splitContainer_ImageMangement.Panel1.Controls.Add(tableLayoutPanel_ImageViewer);
            // 
            // splitContainer_ImageMangement.Panel2
            // 
            splitContainer_ImageMangement.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer_ImageMangement.Size = new Size(833, 609);
            splitContainer_ImageMangement.SplitterDistance = 616;
            splitContainer_ImageMangement.TabIndex = 0;
            // 
            // tableLayoutPanel_ImageViewer
            // 
            tableLayoutPanel_ImageViewer.ColumnCount = 1;
            tableLayoutPanel_ImageViewer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_ImageViewer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel_ImageViewer.Controls.Add(pictureBox_Main, 0, 0);
            tableLayoutPanel_ImageViewer.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel_ImageViewer.Dock = DockStyle.Fill;
            tableLayoutPanel_ImageViewer.Location = new Point(0, 0);
            tableLayoutPanel_ImageViewer.Name = "tableLayoutPanel_ImageViewer";
            tableLayoutPanel_ImageViewer.RowCount = 2;
            tableLayoutPanel_ImageViewer.RowStyles.Add(new RowStyle(SizeType.Percent, 92.1182251F));
            tableLayoutPanel_ImageViewer.RowStyles.Add(new RowStyle(SizeType.Percent, 7.88177347F));
            tableLayoutPanel_ImageViewer.Size = new Size(616, 609);
            tableLayoutPanel_ImageViewer.TabIndex = 0;
            // 
            // pictureBox_Main
            // 
            pictureBox_Main.Dock = DockStyle.Fill;
            pictureBox_Main.Location = new Point(3, 3);
            pictureBox_Main.Name = "pictureBox_Main";
            pictureBox_Main.Size = new Size(610, 555);
            pictureBox_Main.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Main.TabIndex = 0;
            pictureBox_Main.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.63591F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.36409F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 116F));
            tableLayoutPanel1.Controls.Add(button_Next, 0, 0);
            tableLayoutPanel1.Controls.Add(button_MarkAndNext, 0, 0);
            tableLayoutPanel1.Controls.Add(button_Previous, 0, 0);
            tableLayoutPanel1.Controls.Add(button_Mark, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(5, 566);
            tableLayoutPanel1.Margin = new Padding(5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(606, 38);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // button_Next
            // 
            button_Next.Location = new Point(404, 3);
            button_Next.Name = "button_Next";
            button_Next.Size = new Size(82, 23);
            button_Next.TabIndex = 5;
            button_Next.Text = "下一个";
            button_Next.UseVisualStyleBackColor = true;
            button_Next.Click += button_Next_Click;
            // 
            // button_MarkAndNext
            // 
            button_MarkAndNext.Location = new Point(492, 3);
            button_MarkAndNext.Name = "button_MarkAndNext";
            button_MarkAndNext.Size = new Size(101, 23);
            button_MarkAndNext.TabIndex = 4;
            button_MarkAndNext.Text = "标记并下一个";
            button_MarkAndNext.UseVisualStyleBackColor = true;
            button_MarkAndNext.Click += button_MarkAndNext_Click;
            // 
            // button_Previous
            // 
            button_Previous.Location = new Point(3, 3);
            button_Previous.Name = "button_Previous";
            button_Previous.Size = new Size(101, 23);
            button_Previous.TabIndex = 3;
            button_Previous.Text = "上一个";
            button_Previous.UseVisualStyleBackColor = true;
            button_Previous.Click += button_Previous_Click;
            // 
            // button_Mark
            // 
            button_Mark.Location = new Point(186, 3);
            button_Mark.Name = "button_Mark";
            button_Mark.Size = new Size(101, 23);
            button_Mark.TabIndex = 2;
            button_Mark.Text = "标记";
            button_Mark.UseVisualStyleBackColor = true;
            button_Mark.Click += button_Mark_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button_DeleteMark);
            flowLayoutPanel1.Controls.Add(button_DeleteUnmark);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(button_MoveMark);
            flowLayoutPanel1.Controls.Add(button_MoveUnmark);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(button_CopyMark);
            flowLayoutPanel1.Controls.Add(button_CopyUnmark);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(button_ProgressText);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(213, 609);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // button_DeleteMark
            // 
            button_DeleteMark.Location = new Point(3, 3);
            button_DeleteMark.Name = "button_DeleteMark";
            button_DeleteMark.Size = new Size(207, 23);
            button_DeleteMark.TabIndex = 0;
            button_DeleteMark.Text = "删除标记图片";
            button_DeleteMark.UseVisualStyleBackColor = true;
            button_DeleteMark.Click += button_DeleteMark_Click;
            // 
            // button_DeleteUnmark
            // 
            button_DeleteUnmark.Location = new Point(3, 32);
            button_DeleteUnmark.Name = "button_DeleteUnmark";
            button_DeleteUnmark.Size = new Size(207, 23);
            button_DeleteUnmark.TabIndex = 1;
            button_DeleteUnmark.Text = "删除未标记图片";
            button_DeleteUnmark.UseVisualStyleBackColor = true;
            button_DeleteUnmark.Click += button_DeleteUnmark_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 38);
            panel1.TabIndex = 6;
            // 
            // button_MoveMark
            // 
            button_MoveMark.Location = new Point(3, 105);
            button_MoveMark.Name = "button_MoveMark";
            button_MoveMark.Size = new Size(207, 23);
            button_MoveMark.TabIndex = 2;
            button_MoveMark.Text = "移动标记图片";
            button_MoveMark.UseVisualStyleBackColor = true;
            button_MoveMark.Click += button_MoveMark_Click;
            // 
            // button_MoveUnmark
            // 
            button_MoveUnmark.Location = new Point(3, 134);
            button_MoveUnmark.Name = "button_MoveUnmark";
            button_MoveUnmark.Size = new Size(207, 23);
            button_MoveUnmark.TabIndex = 3;
            button_MoveUnmark.Text = "移动未标记图片";
            button_MoveUnmark.UseVisualStyleBackColor = true;
            button_MoveUnmark.Click += button_MoveUnmark_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 163);
            panel3.Name = "panel3";
            panel3.Size = new Size(207, 38);
            panel3.TabIndex = 7;
            // 
            // button_CopyMark
            // 
            button_CopyMark.Location = new Point(3, 207);
            button_CopyMark.Name = "button_CopyMark";
            button_CopyMark.Size = new Size(207, 23);
            button_CopyMark.TabIndex = 4;
            button_CopyMark.Text = "复制标记图片";
            button_CopyMark.UseVisualStyleBackColor = true;
            button_CopyMark.Click += button_CopyMark_Click;
            // 
            // button_CopyUnmark
            // 
            button_CopyUnmark.Location = new Point(3, 236);
            button_CopyUnmark.Name = "button_CopyUnmark";
            button_CopyUnmark.Size = new Size(207, 23);
            button_CopyUnmark.TabIndex = 5;
            button_CopyUnmark.Text = "复制未标记文件";
            button_CopyUnmark.UseVisualStyleBackColor = true;
            button_CopyUnmark.Click += button_CopyUnmark_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(progressBar);
            panel2.Location = new Point(3, 265);
            panel2.Name = "panel2";
            panel2.Size = new Size(207, 28);
            panel2.TabIndex = 7;
            // 
            // progressBar
            // 
            progressBar.Dock = DockStyle.Fill;
            progressBar.Location = new Point(0, 0);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(207, 28);
            progressBar.TabIndex = 0;
            // 
            // button_ProgressText
            // 
            button_ProgressText.Enabled = false;
            button_ProgressText.Location = new Point(3, 299);
            button_ProgressText.Name = "button_ProgressText";
            button_ProgressText.Size = new Size(207, 23);
            button_ProgressText.TabIndex = 8;
            button_ProgressText.Text = "0/0";
            button_ProgressText.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 634);
            Controls.Add(splitContainer_Main);
            Controls.Add(menuStrip_Main);
            MainMenuStrip = menuStrip_Main;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "图片预览标记窗口";
            Load += MainForm_Load;
            menuStrip_Main.ResumeLayout(false);
            menuStrip_Main.PerformLayout();
            splitContainer_Main.Panel1.ResumeLayout(false);
            splitContainer_Main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_Main).EndInit();
            splitContainer_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Files).EndInit();
            splitContainer_ImageMangement.Panel1.ResumeLayout(false);
            splitContainer_ImageMangement.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer_ImageMangement).EndInit();
            splitContainer_ImageMangement.ResumeLayout(false);
            tableLayoutPanel_ImageViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Main).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip_Main;
        private ToolStripMenuItem 文件FToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem_OpenPath;
        private ToolStripMenuItem toolStripMenuItem_ClosePath;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem_Exit;
        private SplitContainer splitContainer_Main;
        private SplitContainer splitContainer_ImageMangement;
        private DataGridView dataGridView_Files;
        private DataGridViewCheckBoxColumn Mark;
        private DataGridViewTextBoxColumn Extension;
        private DataGridViewTextBoxColumn FileName;
        private DataGridViewTextBoxColumn Path;
        private ToolStripMenuItem toolStripMenuItem_RefreshList;
        private ToolStripMenuItem 帮助HToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem_Version;
        private ToolStripMenuItem toolStripMenuItem_About;
        private TableLayoutPanel tableLayoutPanel_ImageViewer;
        private PictureBox pictureBox_Main;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button_Next;
        private Button button_MarkAndNext;
        private Button button_Previous;
        private Button button_Mark;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button_DeleteMark;
        private Button button_DeleteUnmark;
        private Button button_MoveMark;
        private Button button_MoveUnmark;
        private Button button_CopyMark;
        private Button button_CopyUnmark;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private ProgressBar progressBar;
        private Button button_ProgressText;
    }
}