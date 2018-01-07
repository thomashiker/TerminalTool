using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Drawing;
using MetroFramework.Controls;
using System.Xml;

namespace TerminalTool
{
    public partial class SendToolForm : MetroForm
    {
        private MetroTextBox textBox = null;
        private MainForm mainForm = null;
        private bool loopChecked = false;
        private Control ParentControl = null;
        private string _cmdListDefaultFile;


        public MetroColorStyle MetroStyle
        {
            get { return StyleMng.Style; }
            set
            {
                StyleMng.Style = value;
                dividePanel.BackColor = MetroPaint.GetStyleColor(StyleMng.Style);
            }
        }

        public string CmdListDefaultFile
        {
            get { return _cmdListDefaultFile; }
            set
            {
                _cmdListDefaultFile = value;
                reloadToolStripMenuItem.ToolTipText = _cmdListDefaultFile;
            }
        }


        public SendToolForm(MainForm form, MetroTextBox tb)
        {
            InitializeComponent();

            StyleMng.Theme = MetroThemeStyle.Light;
            //StyleManager = StyleMng;
            MetroStyle = MetroColorStyle.Default;
            textBox = tb;
            mainForm = form;

            CmdListDefaultFile = Application.StartupPath + "\\default.xml";
            ReloadFile(false);
        }

        private void SendMsg(string msg)
        {
            mainForm.SendMessage(msg, true);
        }

        public void UpdateLocation()
        {
            if (null != ParentControl)
            {
                this.Width = ParentControl.Width - 1;
                this.Location = ParentControl.PointToScreen(new Point(ParentControl.Left - 3, ParentControl.Height));
            }
        }

        public void ShowHide(Control control)
        {
            if (control == null)
                throw new ArgumentNullException("control");

            ParentControl = control;

            UpdateLocation();
            if (!this.Visible)
                Show(mainForm);
            else
                Hide();
        }

        enum ErrorType
        {
            ERROR,
            WARNING,
            INFO
        }

        private void ShowInfo(string error, ErrorType type)
        {
            switch (type)
            {
                case ErrorType.ERROR:
                    labelInfo.Text = "ERROR: ";
                    labelInfo.BackColor = Color.Crimson;
                    break;
                case ErrorType.WARNING:
                    labelInfo.Text = "WARNING: ";
                    labelInfo.BackColor = Color.DarkOrchid;
                    break;
                case ErrorType.INFO:
                    labelInfo.Text = "INFO: ";
                    labelInfo.BackColor = Color.DeepSkyBlue;
                    break;
                default:
                    break;
            }
            labelInfo.Text += error;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = gridCmdList.CurrentRow;

            if (null != row)
            {
                Clipboard.SetDataObject((string)row.Cells[1].Value);
            }
        }

        private void copyAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = null;

            foreach (DataGridViewRow row in gridCmdList.Rows)
            {
                str = str + row.Cells[1].Value + "\r\n";
            }
            Clipboard.SetDataObject(str);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridCmdList.SelectedRows)
            {
                //gridCmdList.Rows.Remove(row);
                if (!row.IsNewRow)
                    gridCmdList.Rows.Remove(row);
                else
                    gridCmdList.ClearSelection();
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridCmdList.Rows.Clear();
            textBox.Clear();
        }

        public void AddCmdDisc(string cmd, string discription)
        {
            if (null == cmd || 0 == cmd.Length)
                return;

            foreach (DataGridViewRow row in gridCmdList.Rows)
            {
                if (cmd.Equals(row.Cells[1].Value))
                {
                    return;
                }
            }

            int index = gridCmdList.Rows.Add();
            gridCmdList.Rows[index].Cells[1].Value = cmd;
            gridCmdList.Rows[index].Cells[1].ToolTipText = discription;
        }

        public void AddCmd(string item)
        {
            if (null == item || 0 == item.Length)
                return;

            foreach (DataGridViewRow row in gridCmdList.Rows)
            {
                if (item.Equals(row.Cells[1].Value))
                {
                    return;
                }
            }

            int index = gridCmdList.Rows.Add();
            gridCmdList.Rows[index].Cells[1].Value = item;
            gridCmdList.Rows[index].Cells[1].ToolTipText = "no discription";
            //    string[] array = new string[] { "null", item };
            //gridCmdList.Rows.Insert(0, array);
        }

        private void UploadFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.xml)|*.xml";
            ofd.InitialDirectory = Application.StartupPath;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                XmlDocument xml = new XmlDocument();

                xml.Load(@ofd.FileName);

                XmlNodeList nodeList = xml.DocumentElement.GetElementsByTagName("CMD");
                foreach (XmlNode node in nodeList) //当然也能用nodeList的值
                {
                    if (null != node.Attributes["cmd"])
                    {
                        if (null != node.Attributes["discription"])
                        {
                            AddCmdDisc(node.Attributes["cmd"].InnerText, node.Attributes["discription"].InnerText);
                        }
                        else
                        {
                            AddCmd(node.Attributes["cmd"].InnerText);
                        }
                    }
                }
                CmdListDefaultFile = ofd.FileName;
            }  
        }

        private void SaveToFile()
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "(*.xml)|*.xml"; 
            fileDialog.DefaultExt = "xml";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XmlDocument doc = new XmlDocument();
                    XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                    doc.AppendChild(dec);

                    XmlElement root = doc.CreateElement("cmdlist");
                    doc.AppendChild(root);
                    foreach (DataGridViewRow row in gridCmdList.Rows)
                    {
                        XmlElement element = doc.CreateElement("CMD");
                        element.SetAttribute("cmd", (string)row.Cells[1].Value);
                        element.SetAttribute("discription", row.Cells[1].ToolTipText);
                        root.AppendChild(element);
                    }

                    doc.Save(@fileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.Message, "MetroMessagebox");
                }
            }
        }

        private void ReloadFile(bool warning)
        {
            if (!File.Exists(@CmdListDefaultFile))
            {
                if (warning)
                    MetroMessageBox.Show(this, CmdListDefaultFile + ":文件不存在");
                return;
            }

            gridCmdList.Rows.Clear();
            textBox.Clear();

            XmlDocument xml = new XmlDocument();

            xml.Load(@CmdListDefaultFile);

            XmlNodeList nodeList = xml.DocumentElement.GetElementsByTagName("CMD");
            foreach (XmlNode node in nodeList) //当然也能用nodeList的值
            {
                if (null != node.Attributes["cmd"])
                {
                    if (null != node.Attributes["discription"])
                    {
                        AddCmdDisc(node.Attributes["cmd"].InnerText, node.Attributes["discription"].InnerText);
                    }
                    else
                    {
                        AddCmd(node.Attributes["cmd"].InnerText);
                    }
                }
            }
        }

        private void uploadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadFile();
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReloadFile(true);
        }

        private void UpdateOwnerTextBox(string text)
        {
            this.Invoke((EventHandler)(delegate
            {
                textBox.Text = text;
            }));
        }
        private void gridCmdList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            /*foreach (DataGridViewRow row in gridCmdList.SelectedRows)
            {
                UpdateOwnerTextBox((string)row.Cells[1].Value);
                return;
            }*/
            DataGridViewRow row = gridCmdList.CurrentRow;

            if (null != row)
            {
                UpdateOwnerTextBox((string)row.Cells[1].Value);
            }
        }

        private void gridCmdList_SelectionChanged(object sender, EventArgs e)
        {
            /*foreach (DataGridViewRow row in gridCmdList.SelectedRows)
            {
                UpdateOwnerTextBox((string)row.Cells[1].Value);
                return;
            }*/
            DataGridViewRow row = gridCmdList.CurrentRow;

            if (null != row)
            {
                UpdateOwnerTextBox((string)row.Cells[1].Value);
            }
        }

        private int AddGridItem()
        {
            string cmd;
            string name;
            int index;

            NewCmdForm addForm = new NewCmdForm();
            //addForm.Owner = this;
            //addForm.Parent = mainForm.Parent;
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                cmd = addForm.GetNewCmd();
                name = addForm.GetNewCmdName();
                if (null == cmd || 0 == cmd.Length)
                {
                    ShowInfo("Null Cmd", ErrorType.ERROR);
                    return -1;
                }
                index = gridCmdList.Rows.Add();
                gridCmdList.Rows[index].Cells[1].Value = cmd;
                if (null == name || 0 == name.Length)
                {
                    ShowInfo("Not Add Cmd Discription", ErrorType.WARNING);
                    gridCmdList.Rows[index].Cells[1].ToolTipText = "No Discription";
                }
                else
                {
                    gridCmdList.Rows[index].Cells[1].ToolTipText = name;
                    ShowInfo("A New Cmd Added", ErrorType.INFO);
                }
            }
            return 0;
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGridItem();
        }

        private int LoadGridItem()
        {
            string cmd = null;
            string name = null;
            //int index;
            NewCmdForm addForm = new NewCmdForm();
            DataGridViewRow row = gridCmdList.CurrentRow;

            if (null == row)
            {
                return -1;
            }
            //foreach (DataGridViewRow row in gridCmdList.SelectedRows)
            //{
                cmd = (string)row.Cells[1].Value;
                name = row.Cells[1].ToolTipText;
            //    break;
            //}
            

            addForm.SetNewCmd(cmd);
            addForm.SetNewCmdName(name);

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                cmd = addForm.GetNewCmd();
                name = addForm.GetNewCmdName();
                if (null == cmd || 0 == cmd.Length)
                {
                    ShowInfo("Null Cmd", ErrorType.ERROR);
                    return -1;
                }
                //index = gridCmdList.Rows.Add();
                row.Cells[1].Value = cmd;
                if (null == name || 0 == name.Length)
                {
                    ShowInfo("Not Add Cmd Discription", ErrorType.WARNING);
                    row.Cells[1].ToolTipText = "No Discription";
                }
                else
                {
                    DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)row.Cells["ColumnEdit"];
                    checkCell.Value = false;
                    row.Cells[1].ToolTipText = name;
                    ShowInfo("Cmd had modify success", ErrorType.INFO);
                }
            }
            return 0;
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGridItem();
        }

        private void gridCmdList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridCmdList.CurrentRow;
            DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)row.Cells["ColumnEdit"];
            DataGridViewTextBoxCell textCell = (DataGridViewTextBoxCell)row.Cells["ColumnCmd"];
            bool flag = Convert.ToBoolean(checkCell.Value);
            if (flag)
            {
                LoadGridItem();
            }
            else
            {
                SendMsg((string)row.Cells[1].Value);
            }
        }

        private bool LoopChecked
        {
            get { return loopChecked; }
            set
            {
                loopChecked = value;
                if (loopChecked)
                {
                    loopChecked = true;
                    loopToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                    LoopBGWorker.RunWorkerAsync();
                }
                else
                {
                    loopChecked = false;
                    loopToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
                    LoopBGWorker.CancelAsync();
                }
            }
        }

        private void btListSend_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = gridCmdList.CurrentRow;

            if (null != row)
            {
                SendMsg((string)row.Cells[1].Value);
            }
        }

        private void SendToolForm_Deactivate(object sender, EventArgs e)
        {
            if (autoHideToggle.Checked)
            {
                this.TopLevel = false;
                Hide();
                this.TopLevel = true;
            }
        }

        private void selectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = gridCmdList.CurrentRow;

            if (null != row)
            {
                SendMsg((string)row.Cells[1].Value);
            }
        }

        private void SendChecked()
        {
            foreach (DataGridViewRow row in gridCmdList.Rows)
            {
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)row.Cells[0];
                if ((bool)checkCell.EditedFormattedValue)
                {
                    SendMsg((string)row.Cells[1].Value);
                    Thread.Sleep(1);
                }
            }
        }

        private void checkedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendChecked();
        }

        private void loopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainForm.IsPortOpen())
            {
                LoopChecked = !LoopChecked;
            }
            else
            {
                LoopChecked = false;
            }
        }

        private void LoopBGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            do
            {
                foreach (DataGridViewRow row in gridCmdList.Rows)
                {
                    try
                    {
                        DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)row.Cells[0];
                        if ((bool)checkCell.EditedFormattedValue)
                        {
                            SendMsg((string)row.Cells[1].Value);
                            Thread.Sleep(10);
                        }
                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, ex.Message, "MetroMessagebox");
                    }
                    
                    if (LoopBGWorker.CancellationPending)
                    {
                        break;
                    }
                }
            } while (LoopChecked && (!LoopBGWorker.CancellationPending));
        }

        private void LoopBGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }
    }
}
