namespace ImageViewerAndMangementTool
{
    partial class WaitForm
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
            label_Prompt = new Label();
            button_Cancel = new Button();
            SuspendLayout();
            // 
            // label_Prompt
            // 
            label_Prompt.AutoSize = true;
            label_Prompt.Location = new Point(82, 43);
            label_Prompt.Name = "label_Prompt";
            label_Prompt.Size = new Size(92, 17);
            label_Prompt.TabIndex = 0;
            label_Prompt.Text = "读取文件列表中";
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(68, 82);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(75, 23);
            button_Cancel.TabIndex = 1;
            button_Cancel.Text = "取消";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // WaitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(220, 110);
            Controls.Add(button_Cancel);
            Controls.Add(label_Prompt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WaitForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "WaitForm";
            Load += WaitForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Prompt;
        private Button button_Cancel;
    }
}