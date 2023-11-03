using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewerAndMangementTool
{
    public partial class WaitForm : Form
    {

        const int minWidth = 220;
        const int minHeight = 110;
        private Action? _cancelAction = null;
        public WaitForm()
        {
            InitializeComponent();
        }

        private void WaitForm_Load(object sender, EventArgs e)
        {
            SetSize(minWidth, minHeight);
        }

        public WaitForm SetSize(int width, int height)
        {
            if (minWidth > width)
            {
                width = minWidth;
            }
            if (height > minHeight)
            {
                height = minHeight;
            }

            this.Size = new Size(width, height);
            // 计算控件位置
            button_Cancel.Location = new Point((this.Size.Width - button_Cancel.Size.Width) / 2, this.Size.Height - 10 - button_Cancel.Size.Height);
            label_Prompt.Location = new Point((this.Size.Width - label_Prompt.Size.Width) / 2, label_Prompt.Location.Y);
            return this;
        }

        public WaitForm SetSize(int width) { return SetSize(width, this.Size.Height); }

        public DialogResult Show(Action action, Form form)
        {
            if (action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }
            this.Owner = form;
            if (this.IsDisposed)
            {
                return DialogResult.OK;
            }
            else
            {
                return this.ShowDialog();
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            if (_cancelAction != null)
            {
                _cancelAction();
            }
            Close();
        }
    }
}
