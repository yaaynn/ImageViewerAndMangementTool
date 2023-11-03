using ImageViewerAndMangementTool.Forms;
using ImageViewerAndMangementTool.Models;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.IO;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace ImageViewerAndMangementTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private string _basePath = string.Empty;
        private bool _cancleRefreshPath = false;
        private List<FileInformation>? _files = null;
        private const string _historyFileName = "history.ini";
        private int _currentIndex = 0;

        private bool _isRefreshing = false;

        private void MainForm_Load(object sender, EventArgs e)
        {
            splitContainer_Main.FixedPanel = FixedPanel.Panel1;
            splitContainer_ImageMangement.FixedPanel = FixedPanel.Panel2;
            dataGridView_Files.RowHeadersVisible = false;

            _basePath = ReadHistoryFile(_historyFileName);
            dataGridView_Files.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            // tableLayoutPanel_ImageViewer.RowStyles.Add(new RowStyle(SizeType.Absolute, 400));
        }

        private string ReadHistoryFile(string path)
        {

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                try { return File.ReadAllText(fileInfo.FullName, Encoding.UTF8); }
                catch { }
            }
            return string.Empty;
        }

        private void WriteHistoryFile(string path, string content)
        {
            FileInfo file = new FileInfo(path);
            try { File.WriteAllText(file.FullName, content, Encoding.UTF8); }
            catch { }
        }
        private WaitForm OpenWaitForm(Action action)
        {
            WaitForm waitForm = new WaitForm();
            Task.Run(() =>
            {
                this.BeginInvoke(() =>
                {
                    waitForm.Show(action, this);
                });
            });
            return waitForm;
        }

        private void toolStripMenuItem_OpenPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "请选择目录";
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog.ShowNewFolderButton = true;

            if (_basePath != string.Empty)
            {
                folderBrowserDialog.SelectedPath = @$"{_basePath}\";
            }
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                _basePath = folderBrowserDialog.SelectedPath;
                WriteHistoryFile(_historyFileName, _basePath);
                RefreshFilePath(_basePath);
            }
        }

        private void RefreshFilePath(string path)
        {
            /*WaitForm waitForm = OpenWaitForm(() =>
            {
                _cancleRefreshPath = true;
            });*/

            _files = GetFileList(path);

            RefreshFileListView(_files);
            _cancleRefreshPath = false;
            // waitForm.Close();
        }

        private void SetWaitCursor(Action action)
        {
            if (action == null)
            {
                return;
            }
            Action actionCurrent = () =>
            {
                try
                {
                    Cursor cursor = this.Cursor;
                    this.Cursor = Cursors.WaitCursor;
                    Task.Run(() =>
                    {
                        action();
                        this.Invoke(() =>
                        {
                            this.Cursor = cursor;
                        });
                    });
                }
                catch (Exception ex)
                {
                    ShowErrorDialog(ex.Message);
                }
            };
            if (this.InvokeRequired) { this.Invoke(actionCurrent); }
            else { actionCurrent(); }
        }

        /// <summary>
        /// 刷新文件 ListView 列表
        /// </summary>
        /// <param name="files"></param>
        private void RefreshFileListView(List<FileInformation> files)
        {
            SetWaitCursor(() =>
            {
                this.BeginInvoke(() =>
                {
                    _isRefreshing = true;
                    dataGridView_Files.DataSource = null;
                    _isRefreshing = true;
                    dataGridView_Files.DataSource = files;
                    dataGridView_Files.Rows[_currentIndex].Selected = true;
                });
            });
        }

        /// <summary>
        /// 获取文件列表
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private List<FileInformation> GetFileList(string path)
        {
            string[] filedir = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            List<FileInformation> files = new List<FileInformation>();

            foreach (string file in filedir)
            {
                FileInfo fileInfo = new FileInfo(file);

                files.Add(new FileInformation()
                {
                    Path = file,
                    FileName = fileInfo.Name,
                    Extension = fileInfo.Extension
                });
                if (_cancleRefreshPath)
                {
                    return files;
                }
            }
            return files;

        }
        /// <summary>
        /// 菜单-刷新文件列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void toolStripMenuItem_RefreshList_Click(object sender, EventArgs e)
        {
            RefreshFilePath(_basePath);
        }
        /// <summary>
        /// 菜单-关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem_About_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }
        /// <summary>
        /// 文件列表-选择改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_Files_SelectionChanged(object sender, EventArgs e)
        {
            if (_isRefreshing)
            {
                _isRefreshing = false;
                if (_files.Count() <= _currentIndex)
                {
                    _currentIndex = _files.Count() - 1;
                }
                return;
            }

            // 判断选定行是否在可视窗口内
            if (_currentIndex < dataGridView_Files.FirstDisplayedScrollingRowIndex ||
                _currentIndex >= dataGridView_Files.FirstDisplayedScrollingRowIndex + dataGridView_Files.DisplayedRowCount(true))
            {
                // 选定行不在可视窗口内，将其滚动到可视窗口内
                dataGridView_Files.FirstDisplayedScrollingRowIndex = _currentIndex;
            }

            if (dataGridView_Files.SelectedRows.Count == 0) return;

            _currentIndex = dataGridView_Files.SelectedRows[0].Index;

            FileInformation fileInformation = _files[_currentIndex];
            if (fileInformation.Mark)
            {
                button_Mark.Text = "取消标记";
                button_MarkAndNext.Text = "取消标记并下一个";
            }
            else
            {
                button_Mark.Text = "标记";
                button_MarkAndNext.Text = "标记并下一个";
            }

            RefreshImage(_currentIndex);
        }

        private void RefreshImage(int index)
        {
            FreedImage();

            if (_files == null || index < 0 || _files.Count() <= index) return;

            FileInformation fileInformation = _files[index];
            if (fileInformation == null) return;

            pictureBox_Main.Image = new System.Drawing.Bitmap(fileInformation.Path);

        }
        private void ChangeImage(int index)
        {
            _currentIndex = index;
            if (_currentIndex < 0) _currentIndex = 0;
            if (_currentIndex >= _files.Count()) _currentIndex = _files.Count() - 1;
            RefreshImage(_currentIndex);
            dataGridView_Files.Rows[_currentIndex].Selected = true;

        }
        private void MarkImage(int index)
        {
            if (_files == null || _files.Count() == 0)
            {
                return;
            }
            _files[_currentIndex].Mark = !_files[_currentIndex].Mark;
            RefreshFileListView(_files);
            dataGridView_Files.Rows[_currentIndex].Selected = true;
        }

        private List<FileInformation> FilterFiles(List<FileInformation> files, bool mark = true)
        {
            List<FileInformation> filterFiles = new List<FileInformation>();
            foreach (FileInformation file in files)
            {
                if (file.Mark == mark)
                {
                    filterFiles.Add(file);
                }
            }
            return filterFiles;
        }

        private void button_Previous_Click(object sender, EventArgs e)
        {
            ChangeImage(_currentIndex - 1);
        }

        private void button_Mark_Click(object sender, EventArgs e)
        {
            MarkImage(_currentIndex);
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            ChangeImage(_currentIndex + 1);
        }

        private void button_MarkAndNext_Click(object sender, EventArgs e)
        {
            MarkImage(_currentIndex);
            ChangeImage(_currentIndex + 1);
        }

        // 释放pictureBox中的图片
        private void FreedImage()
        {
            if (pictureBox_Main.Image != null)
            {
                pictureBox_Main.Image.Dispose();
                pictureBox_Main.Image = null;
            }
        }

        private void ChangeProgress(int maximum, int current)
        {
            Action action = () =>
            {
                progressBar.Value = current;
                progressBar.Maximum = maximum;
                button_ProgressText.Text = $"{current}/{maximum}";
            };

            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }
        private void ShowErrorDialog(string content)
        {
            Action action = () =>
            {
                MessageBox.Show(content, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }
        /// <summary>
        /// 删除标记的图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_DeleteMark_Click(object sender, EventArgs e)
        {
            FreedImage();
            if (MessageBox.Show("确定删除标记的图片吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            SetWaitCursor(() =>
            {
                List<FileInformation> files = FilterFiles(_files, true);
                int total = files.Count();
                ChangeProgress(total, 0);

                for (int i = 0; i < total; i++)
                {
                    try
                    {
                        File.Delete(files[i].Path);
                    }
                    catch (Exception ex)
                    {
                        ShowErrorDialog(ex.Message);
                    }

                    ChangeProgress(total, i + 1);
                }
                _currentIndex = 0;
                RefreshFilePath(_basePath);
            });
        }
        /// <summary>
        /// 删除未标记的图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_DeleteUnmark_Click(object sender, EventArgs e)
        {
            FreedImage();
            if (MessageBox.Show("确定删除未标记的图片吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            SetWaitCursor(() =>
            {

            });
            List<FileInformation> files = FilterFiles(_files, false);
            int total = files.Count();
            ChangeProgress(total, 0);
            for (int i = 0; i < total; i++)
            {
                try
                {
                    File.Delete(files[i].Path);
                }
                catch (Exception ex)
                {
                    ShowErrorDialog(ex.Message);
                }
                ChangeProgress(total, i + 1);
            }
            _currentIndex = 0;
            RefreshFilePath(_basePath);
        }
        /// <summary>
        /// 选择文件夹
        /// </summary>
        /// <returns></returns>
        private string SelectedPath()
        {
            FreedImage();
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "请选择文件夹";
            folderBrowserDialog.ShowNewFolderButton = true;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                return folderBrowserDialog.SelectedPath;
            }
            return string.Empty;
        }
        /// <summary>
        /// 打开文件夹
        /// </summary>
        /// <param name="directoryPath"></param>
        private void OpenDirectoryPath(string directoryPath)
        {
            Action action = () =>
            {
                try
                {
                    // 使用Process.Start打开文件资源管理器，并指定目录路径
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = "explorer.exe";
                    startInfo.Arguments = directoryPath;
                    Process.Start(startInfo);
                }
                catch (Exception ex)
                {
                    ShowErrorDialog(ex.Message);
                }
            };
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }
        /// <summary>
        /// 移动标记的图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_MoveMark_Click(object sender, EventArgs e)
        {
            FreedImage();
            string path = SelectedPath();


            if (!string.IsNullOrEmpty(path))
            {

                SetWaitCursor(() =>
                {
                    List<FileInformation> files = FilterFiles(_files, true);
                    int total = files.Count();
                    ChangeProgress(total, 0);
                    for (int i = 0; i < total; i++)
                    {
                        try
                        {
                            File.Move(files[i].Path, System.IO.Path.Combine(path, files[i].FileName));
                        }
                        catch (Exception ex)
                        {
                            ShowErrorDialog(ex.Message);
                        }
                        ChangeProgress(total, i + 1);
                    }
                    _currentIndex = 0;
                    RefreshFilePath(_basePath);
                    OpenDirectoryPath(path);
                });

            }
        }

        private void button_MoveUnmark_Click(object sender, EventArgs e)
        {
            FreedImage();
            string path = SelectedPath();
            if (!string.IsNullOrEmpty(path))
            {

                SetWaitCursor(() =>
                {
                    List<FileInformation> files = FilterFiles(_files, false);
                    int total = files.Count();
                    ChangeProgress(total, 0);
                    for (int i = 0; i < total; i++)
                    {
                        try
                        {
                            File.Move(files[i].Path, System.IO.Path.Combine(path, files[i].FileName));
                        }
                        catch (Exception ex)
                        {
                            ShowErrorDialog(ex.Message);
                        }
                        ChangeProgress(total, i + 1);
                    }
                    _currentIndex = 0;
                    RefreshFilePath(_basePath);
                    OpenDirectoryPath(path);
                });

            }
        }

        private void button_CopyMark_Click(object sender, EventArgs e)
        {
            FreedImage();
            string path = SelectedPath();
            if (!string.IsNullOrEmpty(path))
            {

                SetWaitCursor(() =>
                {
                    List<FileInformation> files = FilterFiles(_files, true);
                    int total = files.Count();
                    ChangeProgress(total, 0);
                    for (int i = 0; i < total; i++)
                    {
                        try
                        {
                            File.Copy(files[i].Path, System.IO.Path.Combine(path, files[i].FileName));
                        }
                        catch (Exception ex)
                        {
                            ShowErrorDialog(ex.Message);
                        }
                        ChangeProgress(total, i + 1);
                    }
                    _currentIndex = 0;
                    RefreshFilePath(_basePath);
                    OpenDirectoryPath(path);
                });

            }
        }

        private void button_CopyUnmark_Click(object sender, EventArgs e)
        {
            FreedImage();
            string path = SelectedPath();
            if (!string.IsNullOrEmpty(path))
            {

                SetWaitCursor(() =>
                {
                    List<FileInformation> files = FilterFiles(_files, false);
                    int total = files.Count();
                    ChangeProgress(total, 0);
                    for (int i = 0; i < total; i++)
                    {
                        try
                        {
                            File.Copy(files[i].Path, System.IO.Path.Combine(path, files[i].FileName));
                        }
                        catch (Exception ex)
                        {
                            ShowErrorDialog(ex.Message);
                        }
                        ChangeProgress(total, i + 1);
                    }
                    _currentIndex = 0;
                    RefreshFilePath(_basePath);
                    OpenDirectoryPath(path);
                });

            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Space:
                case Keys.Up:
                    MarkImage(_currentIndex);
                    break;
                case Keys.Down:
                    MarkImage(_currentIndex);
                    ChangeImage(_currentIndex + 1);
                    break;
                case Keys.Left:
                    ChangeImage(_currentIndex - 1);
                    break;
                case Keys.Right:
                    ChangeImage(_currentIndex + 1);
                    break;

            }


            return base.ProcessCmdKey(ref msg, keyData);
        }

        #region 取消按键效果
        private void dataGridView_Files_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void dataGridView_Files_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dataGridView_Files_KeyUp(object sender, KeyEventArgs e)
        {

        } 
        #endregion
    }
}