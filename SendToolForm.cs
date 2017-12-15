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


        public MetroColorStyle MetroStyle
        {
            get { return StyleMng.Style; }
            set
            {
                StyleMng.Style = value;
                dividePanel.BackColor = MetroPaint.GetStyleColor(StyleMng.Style);
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
                this.Location = ParentControl.PointToScreen(new Point(ParentControl.Left - 1, ParentControl.Height));
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
            foreach (DataGridViewRow row in gridCmdList.Rows)
            {
                Clipboard.SetDataObject((string)row.Cells[1].Value);
                return;
            }
        }

        private void copyAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = null;

            foreach (DataGridViewRow row in gridCmdList.Rows)
            {
                str = str + row.Cells[1].Value + "\r";
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

        private void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*foreach (DataGridViewRow row in gridCmdList.SelectedRows)
            {
                SendMsg((string)row.Cells[1].Value);
                break;
            }*/
            DataGridViewRow row = gridCmdList.CurrentRow;

            if (null != row)
            {
                SendMsg((string)row.Cells[1].Value);
            }
        }

        public void AddGridItem(string cmd, string discription)
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

        public void AddItem(string item)
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
            gridCmdList.Rows[index].Cells[1].ToolTipText = "Add from file";
            //    string[] array = new string[] { "null", item };
            //gridCmdList.Rows.Insert(0, array);
        }

        private void uploadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.txt)|*.txt";
            ofd.InitialDirectory = Application.StartupPath;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8);

                string content = streamReader.ReadLine();
                while (content != null)
                {
                    if (content.Length > 0)
                        AddItem(content);
                    //lbTextList.Items.Add(content);
                    content = streamReader.ReadLine();
                }
            }
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            fileDialog.DefaultExt = "txt";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();

                    foreach (DataGridViewRow row in gridCmdList.Rows)
                    {
                        sb.AppendLine((string)row.Cells[1].Value);
                    }
                    File.WriteAllText(fileDialog.FileName, sb.ToString());
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.Message, "MetroMessagebox");
                }
            }
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

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\cmdlist.xml";

            if (!File.Exists(@path))
            {
                MessageBox.Show(path + ":文件不存在");
                return;
            }

            XmlDocument xml = new XmlDocument();
            
            xml.Load(@path);

            XmlNodeList nodeList = xml.DocumentElement.GetElementsByTagName("CMD");
            foreach (XmlNode node in nodeList) //当然也能用nodeList的值
            {
                //node.Attributes["Name"].InnerText;
                AddGridItem(node.Attributes["cmd"].InnerText, node.Attributes["discription"].InnerText);
            }
        }

        private void UploadFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.txt)|*.txt";
            ofd.InitialDirectory = Application.StartupPath;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8);

                string content = streamReader.ReadLine();
                while (content != null)
                {
                    if (content.Length > 0)
                        AddItem(content);
                    //lbTextList.Items.Add(content);
                    content = streamReader.ReadLine();
                }

                streamReader.Close();
            }
        }

        private void SaveToFile()
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            fileDialog.DefaultExt = "txt";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();

                    foreach (DataGridViewRow row in gridCmdList.Rows)
                    {
                        sb.AppendLine((string)row.Cells[1].Value);
                    }
                    File.WriteAllText(fileDialog.FileName, sb.ToString());
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.Message, "MetroMessagebox");
                }
            }
        }

        private void uploadFileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UploadFile();
        }

        private void saveToFileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveToFile();
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
                }
                else
                {
                    loopChecked = false;
                    loopToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
                }
            }
        }

        private void loopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoopChecked = !LoopChecked;
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
    }
}
