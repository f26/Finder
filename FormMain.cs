using BrightIdeasSoftware;
using System.Diagnostics;

namespace Finder
{
    public partial class FormMain : Form
    {
        private uint _count = 0;
        private long _findSizeLimit = 0;
        private bool _findSizeGreaterThan = true;
        private long _findTimeLimitSec = 0;
        private bool _findTimeNewerThan = true;
        private string _errorLog = "";
        private Color _defaultLabelColor = Color.Black;
        private bool _caseSensitive = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            try
            {
                resetGuiSearchBegin();
                determineLimitingFactors();
                olv.SetObjects(GetFSItems(textBoxSearchText.Text, new DirectoryInfo(textBoxSearchPath.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.ToString());
            }

            resetGuiSearchEnd();
        }

        private List<FSItem> GetFSItems(string needle, DirectoryInfo haystack)
        {
            StringComparison comparisonMethod = StringComparison.OrdinalIgnoreCase;
            if (_caseSensitive) comparisonMethod = StringComparison.Ordinal;

            List<FSItem> items = new List<FSItem>();

            if (haystack.Name.Contains(needle, comparisonMethod))
            {
                items.Add(new FSItem(haystack));
                _count++;
            }
            try
            {
                foreach (DirectoryInfo subdir in haystack.GetDirectories())
                {
                    if (_count % 25 == 0) // Don't update for every single one for speed purposes
                    {
                        toolStripStatusLabel1.Text = subdir.Name;
                        labelCount.Text = _count.ToString() + " items found";
                        Application.DoEvents();
                    }
                    items.AddRange(GetFSItems(needle, subdir));
                }
            }
            catch (Exception ex) // Might not have access to some dirs
            {
                _errorLog += ex.Message + "\n";
            }

            try
            {
                foreach (FileInfo finfo in haystack.GetFiles())
                {
                    if (!finfo.Name.Contains(needle, comparisonMethod)) continue;

                    bool includeIt = true;

                    if (_findSizeLimit > 0)
                    {
                        if ((_findSizeGreaterThan && finfo.Length < _findSizeLimit) ||
                             (!_findSizeGreaterThan && finfo.Length > _findSizeLimit))
                        {
                            includeIt = false;
                        }
                    }

                    if (_findTimeLimitSec > 0)
                    {
                        double diff = (DateTime.Now - finfo.LastWriteTime).TotalSeconds;
                        if ((_findTimeNewerThan && diff > _findTimeLimitSec) ||
                            (!_findTimeNewerThan && diff < _findTimeLimitSec))
                        {
                            includeIt = false;
                        }
                    }

                    if (includeIt)
                    {
                        items.Add(new FSItem(finfo));
                        _count++;
                    }
                }
            }
            catch (Exception ex) // Might not have access to some dirs
            {
                _errorLog += ex.Message + "\n";
            }

            return items;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormMain_Resize(null, null);
            comboBoxSizeUnit.SelectedIndex = 2;
            comboBoxTimeUnit.SelectedIndex = 0;

            string testdir = Clipboard.GetText();
            if (Directory.Exists(testdir))
            {
                textBoxSearchPath.Text = testdir;
            }
            else if (Directory.Exists(Properties.Settings.Default.SearchPath))
            {
                // Note: Settings are automagically stored at C:\Users\[NAME]\AppData\Local\Finder\...
                textBoxSearchPath.Text = Properties.Settings.Default.SearchPath;
            }

            _defaultLabelColor = labelCount.ForeColor;
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            olv.Width = this.ClientSize.Width - olv.Left * 2;
            olv.Height = this.ClientSize.Height - olv.Top - olv.Left - toolStripStatusLabel1.Height;
        }

        private void textBoxSearchText_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            buttonFind_Click(null, null);
        }

        private void checkBoxSizeLimit_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxLimitSize.Enabled = checkBoxSizeLimit.Checked;
        }

        private void checkBoxTimeLimit_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxLimitTime.Enabled = checkBoxTimeLimit.Checked;
        }

        private void resetGuiSearchBegin()
        {
            _count = 0;
            _errorLog = "";
            labelCount.ForeColor = _defaultLabelColor;
            olv.Items.Clear();
            olv.Enabled = buttonFind.Enabled = textBoxSearchPath.Enabled = textBoxSearchText.Enabled = false;
            labelCount.Text = "Searching...";
            Application.DoEvents();
        }

        private void resetGuiSearchEnd()
        {
            // Resize name column to try to prevent filenames from being cut off
            colName.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);

            // Save the settings
            Properties.Settings.Default.SearchPath = textBoxSearchPath.Text;
            Properties.Settings.Default.Save();

            labelCount.Text = _count.ToString() + " items found";
            olv.Enabled = buttonFind.Enabled = textBoxSearchPath.Enabled = textBoxSearchText.Enabled = true;
            toolStripStatusLabel1.Text = "Ready";
            pictureBoxRover.Visible = true;

            if (_errorLog.Length != 0)
            {
                labelCount.Text += " (!)";
                labelCount.ForeColor = Color.Red;
            }
        }

        private void determineLimitingFactors()
        {
            // Read the various GUI elements that restrict matches and save them off so they
            // can be used during the search operation

            _findSizeLimit = 0;
            try
            {
                if (checkBoxSizeLimit.Checked)
                {
                    long multiplier = 1;
                    switch (comboBoxSizeUnit.Text)
                    {
                        case "KB": multiplier = 1024; break;
                        case "MB": multiplier = 1024 * 1024; break;
                        case "GB": multiplier = 1024 * 1024 * 1024; break;
                    }
                    _findSizeLimit = Convert.ToInt64(textBoxSizeLimit.Text) * multiplier;
                    _findSizeGreaterThan = radioButton3.Checked;
                }
            }
            catch { }

            _findTimeLimitSec = 0;
            try
            {
                if (checkBoxTimeLimit.Checked)
                {
                    long multiplier = 1;
                    switch (comboBoxTimeUnit.Text)
                    {
                        case "hours": multiplier = 3600; break;
                        case "days": multiplier = 3600 * 24; break;
                        case "months": multiplier = 3600 * 24 * 30; break;
                        case "years": multiplier = 3600 * 24 * 365; break;
                    }
                    _findTimeLimitSec = Convert.ToInt64(textBoxTimeLimit.Text) * multiplier;
                    _findTimeNewerThan = radioButton5.Checked;
                }
            }
            catch { }

            _caseSensitive = checkBoxCaseSensitive.Checked;
        }

        private void olv_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && olv.SelectedItems.Count == 1)
            {
                ContextMenuStrip cms = new ContextMenuStrip();
                ToolStripMenuItem tmi = new ToolStripMenuItem("Open containing folder");
                tmi.Click += Tmi_Click;
                tmi.Tag = olv.SelectedObject;
                cms.Items.Add(tmi);
                cms.Show(Cursor.Position);
            }
        }

        private void Tmi_Click(object sender, EventArgs e)
        {
            try
            {
                FSItem item = (FSItem)((ToolStripMenuItem)sender).Tag;
                string args = string.Format("/e, /select, \"{0}\"", item.Path + item.Name);
                StartExplorer(args);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void olv_DoubleClick(object sender, EventArgs e)
        {
            if (olv.SelectedItems.Count == 1 && olv.SelectedObject != null)
            {
                StartExplorer(olv.SelectedObject.ToString());
            }
        }

        private void StartExplorer(string args)
        {
            // https://stackoverflow.com/questions/334630/opening-a-folder-in-explorer-and-selecting-a-file
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "explorer";
            info.Arguments = args;
            Process.Start(info);
        }

        private void olv_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete) return;

            foreach (OLVListItem item in olv.SelectedItems)
            {
                FSItem fsitem = item.RowObject as FSItem;
                try
                {
                    if (fsitem.IsFile())
                    {
                        File.Delete(fsitem.ToString());
                        olv.RemoveObject(fsitem);
                    }
                    else
                    {
                        Directory.Delete(fsitem.ToString(), true);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while deleting item: " + item.ToString() +
                        ".  Not all items were deleted.\n\n" + ex.ToString());
                    break;
                }
            }
            // Refresh the search now that (some) items (may) have been deleted
            buttonFind_Click(null, null);
        }

        private void labelCount_Click(object sender, EventArgs e)
        {
            if (_errorLog.Length > 0) MessageBox.Show(_errorLog);
        }
    }
}