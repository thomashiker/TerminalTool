using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Drawing;
using PortSettingContextMenu;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;
using System.Management;
using CSharpWin;


namespace TerminalTool
{
    public partial class MainForm : MetroForm
    {
        private int zoombase = 80;
        private string SavedLogPath;
        private string openLogFileApplication = "notepad++.exe";
        private string logPath = "log";
        private string logFileName = null;
        private Int64 rcvCharNum = 0;
        private Int64 sendCharNum = 0;
        private Int64 TimeElapse = 0;
        private bool btLoopChecked = false;
        private Color styleColor;
        private bool recordState = true;
        private bool sendTBMLoopChecked = false;
        private bool fctbRcvAutoScroll = true;

        private SendToolForm sendTool;
        private FileSettingForm fileSettingForm;

        private PortSettingContainer portSelectMenu = new PortSettingContainer();
        //private TextListContainer sentList = new TextListContainer();



        public string LogPath
        {
            get { return SavedLogPath; }
            set { SavedLogPath = value; }
        }

        public string LogFile
        {
            get { return logFileName; }
            set { logFileName = value; }
        }

        public Color StyleColor
        {
            get { return styleColor; }
            set {
                if (value == Color.Blue)
                {
                    //styleColor = Color.FromArgb();
                }
                else
                {
                    styleColor = value;
                }
            }
        }

        private bool SendTBMLoopChecked
        {
            get { return sendTBMLoopChecked; }
            set
            {
                if (sendTBMLoop.DisplayStyle == ToolStripItemDisplayStyle.Text)
                {
                    sendTBMLoopChecked = true;
                    sendTBMLoop.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                }
                else
                {
                    sendTBMLoopChecked = false;
                    sendTBMLoop.DisplayStyle = ToolStripItemDisplayStyle.Text;
                }
            }
        }

        private void trackBarZoomInit()
        {
            trackBarZoom.Value = 100 - zoombase;
            trackBarZoom.Maximum = 200 - zoombase;
        }

        private void portSettingContextMenu_closed(object sender, ToolStripDropDownClosingEventArgs e)
        {
            ClosePort();

            serialPort.PortName = portSelectMenu.Port.PortName;
            serialPort.BaudRate = portSelectMenu.Port.BaudRate;
            serialPort.DataBits = portSelectMenu.Port.DataBits;
            serialPort.StopBits = portSelectMenu.Port.StopBits;
            serialPort.Parity = portSelectMenu.Port.Parity;

            OpenPort();
        }

        public MainForm()
        {
            InitializeComponent();

            sendTool = new SendToolForm(this, tbSend);
            fileSettingForm = new FileSettingForm(this);

            /*user init*/
            styleColor = MetroPaint.GetStyleColor(this.Style);
            SetStyleColor(styleColor);
            trackBarZoomInit();
            portSelectMenu.Closing += new ToolStripDropDownClosingEventHandler(portSettingContextMenu_closed);
            SavedLogPath = System.Environment.CurrentDirectory;
            FCTBAutoScroll = true;

            
        }

        private void LogToFile(string data)
        {
            if (recordState)
            {
                if (this.LogFile == null)
                {
                    CreateLogFile();
                }

                try
                {
                    File.AppendAllText(this.LogFile, data);
                    //File.AppendAllText（String， String， Encoding）
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AppendRcvText(string text)
        {
            LogToFile(text);
            fctbRcv.AppendText(text);
            if (fctbRcvAutoScroll)
            {
                fctbRcv.GoEnd();
            }
        }

        bool PortInit()
        {
            serialPort.Encoding = System.Text.Encoding.GetEncoding("UTF8");

            return true;
        }

        private string GetPortSetting()
        {
            string state = null;

            if (null != serialPort)
            {
                state = serialPort.PortName + ","
                        + serialPort.BaudRate.ToString() + ","
                        + serialPort.DataBits.ToString() + ","
                        + serialPort.StopBits.ToString() + ","
                        + serialPort.Parity.ToString();
            }

            return state;
        }

        private bool IsPortOpen()
        {
            return serialPort.IsOpen;
        }

        private void PortStateUpdate()
        {
            if (IsPortOpen())
            {
                btOpen.Image = global::TerminalTool.Properties.Resources.connect;
                labelConnect.Text = GetPortSetting();
                //labelConnect.Font = new Font(labelConnect.Font, FontStyle.Regular);
                //labelConnect.ForeColor = Color.Green;
                labelConnect.UseCustomForeColor = false;

                LinkTimer.Start();
            }
            else
            {
                btOpen.Image = global::TerminalTool.Properties.Resources.connection_error;
                //lableConectState.Text = "No Conection";
                labelConnect.Font = new Font(labelConnect.Font, FontStyle.Strikeout);
                //labelConnect.ForeColor = Color.Red;
                labelConnect.UseCustomForeColor = true;

                LinkTimer.Stop();
            }
            this.UpdateStyles();
        }

        private bool OpenPort()
        {
            if (null == serialPort)
                return false;

            if (!IsPortOpen())
            {
                //MessageBox.Show(serialPort.PortName + " is openning!");
                try
                {
                    serialPort.Open();
                }
                catch
                {
                }
            }

            CreateLogFile();

            PortStateUpdate();

            return true;
        }

        private bool ClosePort()
        {
            if (null == serialPort)
                return false;

            if (IsPortOpen())
            {
                try
                {
                    serialPort.Close();
                }
                catch
                {
                }
            }

            PortStateUpdate();

            return true;
        }

        private void trackBarZoom_ValueChanged(object sender, EventArgs e)
        {
            int percent = trackBarZoom.Value + zoombase;
            fctbRcv.Zoom = percent;
            linkZoom.Text = percent.ToString() + "%";
        }

        private void linkZoom_Click(object sender, EventArgs e)
        {
            trackBarZoom.Value = 100 - zoombase;
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            if (IsPortOpen())
            {
                ClosePort();
            }
            else
            {
                OpenPort();
            }
        }

        private void SaveToFileAs()
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.InitialDirectory = System.Environment.CurrentDirectory;
            fileDialog.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            fileDialog.DefaultExt = "txt";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fctbRcv.SaveToFile(fileDialog.FileName, Encoding.GetEncoding("GB2312"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btSaveRcv_Click(object sender, EventArgs e)
        {
            SaveToFileAs();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            portSelectMenu.Show(this, new Point(btNew.Left, btNew.Bottom));
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            fctbRcv.Clear();
            rcvCharNum = 0;
        }

        private void btLine_Click(object sender, EventArgs e)
        {
            fctbRcv.ShowLineNumbers = !fctbRcv.ShowLineNumbers;
            if (!fctbRcv.ShowLineNumbers)
            {
                fctbRcv.Bookmarks.Clear();
            }
        }

        private void btTag_Click(object sender, EventArgs e)
        {
            //fctbRcv.Bookmarks.Clear();
            int line = 0;
            while (line < fctbRcv.LinesCount)
            {
                fctbRcv.Bookmarks.Remove(line);
                line++;
            }
        }

        private void btRecord_Click(object sender, EventArgs e)
        {
            recordState = !recordState;
            if (recordState)
            {
                btRecord.Image = global::TerminalTool.Properties.Resources.MD_record; //toolStripimageList.Images[11];
                menuToolTip.ToolTipTitle = "Record";
            }
            else
            {
                btRecord.Image = global::TerminalTool.Properties.Resources.MD_stop;//toolStripimageList.Images[12];
                menuToolTip.ToolTipTitle = "Stop Record";
            }
        }

        private string CreateLogFile()
        {
            if (!Directory.Exists(logPath))
            {
                Directory.CreateDirectory(logPath);
            }
            //if (this.LogFile == null)
            //{
            this.LogFile = logPath + "\\" + "[" + serialPort.PortName + "]" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
            //}
            /*            else
                        {
                            this.LogFile = "[" + serialPort.PortName + "]" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
                        }*/

            if (!File.Exists(this.LogFile))
            {
                FileStream fs = new FileStream(this.LogFile, FileMode.Create, FileAccess.ReadWrite);
                fs.Close();
            }

            return this.LogFile;
        }

        private void btNewLog_Click(object sender, EventArgs e)
        {
            CreateLogFile();
        }

        private void btOpenLogWithApp_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(openLogFileApplication, this.LogFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btOpenDir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("Explorer.exe");
            psi.Arguments = "/e,/select," + SavedLogPath;
            System.Diagnostics.Process.Start(psi);
        }

        private void btGoBackward_Click(object sender, EventArgs e)
        {
            fctbRcv.NavigateBackward();
        }

        private void btGoForward_Click(object sender, EventArgs e)
        {
            fctbRcv.NavigateForward();
        }

        private void btFindPrevious_Click(object sender, EventArgs e)
        {
            //fctbRcv.findForm.FCBFindPrevious();
        }

        private void btFindNext_Click(object sender, EventArgs e)
        {
            //fctbRcv.findForm.FCBFindNext();
        }

        private void btScreenShot_Click(object sender, EventArgs e)
        {
            CaptureImageTool capture = new CaptureImageTool();

            capture.SelectCursor = Cursors.Default;
            capture.DrawCursor = Cursors.Default;
            if (capture.ShowDialog() == DialogResult.OK)
            {
            }
        }


        public bool FCTBAutoScroll
        {
            get { return fctbRcvAutoScroll; }
            set
            {
                fctbRcvAutoScroll = value;
                if (fctbRcvAutoScroll)
                {
                    btAutoScroll.BackColor = btAutoScroll.FlatAppearance.MouseOverBackColor;
                }
                else
                {
                    btAutoScroll.BackColor = this.BackColor;
                }
            }
        }

        private void btAutoScroll_Click(object sender, EventArgs e)
        {
            FCTBAutoScroll = !FCTBAutoScroll;
        }

        private void btTopMost_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
            if (TopMost)
            {
                btTopMost.BackColor = btTopMost.FlatAppearance.MouseOverBackColor;//Color.Teal;//this.Style.ToColor;
            }
            else
            {
                btTopMost.BackColor = this.BackColor;
            }
        }

        private void fctbRcv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.X < fctbRcv.LeftIndent)
            {
                var place = fctbRcv.PointToPlace(e.Location);
                if (fctbRcv.Bookmarks.Contains(place.iLine))
                    fctbRcv.Bookmarks.Remove(place.iLine);
                else
                    fctbRcv.Bookmarks.Add(place.iLine);
            }
        }

        public string MsgToSend
        {
            get { return tbSend.Text; }
            set
            {
                this.Invoke((EventHandler)(delegate
                {
                    tbSend.Text = value;
                }));
            }
        }

        private void ReceiveUserInput(string input)
        {
            MsgToSend = MsgToSend + input;
        }

        private void MinusUserInputChar()
        {
            string userInputMsg = MsgToSend;

            if (null != userInputMsg)
            {
                if (userInputMsg.Length > 1)
                {
                    userInputMsg = userInputMsg.Remove(userInputMsg.Length - 1);
                }
                else
                {
                    userInputMsg = null;
                }
            }

            MsgToSend = userInputMsg;
        }

        private void fctbRcv_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    ReceiveUserInput("\n");
                    StringBuilder sendMsgBuilder = new StringBuilder(MsgToSend);
                    SendMessage(sendMsgBuilder.ToString(), true);
                    MsgToSend = null;
                    e.Handled = true;
                    break;
                case Keys.Back:
                    MinusUserInputChar();
                    e.Handled = true;
                    break;
                case Keys.Delete:
                    e.Handled = true;
                    break;
                default:
                    break;
            }
        }

        private void fctbRcv_KeyPress(object sender, KeyPressEventArgs e)
        {
            char input = e.KeyChar;

            if (input > 31 && input < 126)
            {
                ReceiveUserInput(input.ToString());
            }
        }

        private void fctbRcv_KeyPressed(object sender, KeyPressEventArgs e)
        {
            char input = e.KeyChar;

            if (input > 31 && input < 126)
            {
                ReceiveUserInput(input.ToString());
            }
        }

        private void fctbRcv_ZoomChanged(object sender, EventArgs e)
        {
            //int percent = trackBarZoom.Value + zoombase;
            //fctbRcv.Zoom = percent;
            //linkZoom.Text = percent.ToString() + "%";

            //trackBarZoom.SuspendLayout();
            //if (fctbRcv.Zoom > trackBarZoom.Maximum)
            //{
            //    fctbRcv.Zoom = trackBarZoom.Maximum;
            //}
            //trackBarZoom.Value = fctbRcv.Zoom;
            //trackBarZoom.ResumeLayout();
            //labelZoomState.Text = fctbRcv.Zoom.ToString() + "%";
        }

        private void UpdateLinkTimeDisplay(Int64 time)
        {
            Int64 seconds;
            Int64 hours;
            Int64 minutes;

            this.Invoke((EventHandler)(delegate
            {
                seconds = time % 60;
                hours = time / 60;
                minutes = (hours) % 60;
                hours = hours / 60;
                labelTime.Text = hours.ToString().PadLeft(2, '0') + ":" + minutes.ToString().PadLeft(2, '0') + ":" + seconds.ToString().PadLeft(2, '0');
            }));
        }

        private void LinkTimer_Tick(object sender, EventArgs e)
        {
            TimeElapse++;
            UpdateLinkTimeDisplay(TimeElapse);
        }

        private void UpdateRcvCharDisplay(Int64 num)
        {
            labelRcv.Text = "r:" + num.ToString();
        }
        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int n = serialPort.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致  
            byte[] buf = new byte[n];//声明一个临时数组存储当前来的串口数据  
            rcvCharNum += n;//增加接收计数  
            serialPort.Read(buf, 0, n); ;//读取缓冲数据

            StringBuilder builder = new StringBuilder();
            builder.Clear();//清除字符串构造器的内容  
            //因为要访问ui资源，所以需要使用invoke方式同步ui。  
            this.Invoke((EventHandler)(delegate
            {
                //直接按ASCII规则转换成字符串  
                builder.Append(Encoding.ASCII.GetString(buf));
                //追加的形式添加到文本框末端，并滚动到最后。  
                /*fctbRcv.AppendText(builder.ToString());
                if (fctbRcvAutoScroll)
                {
                    fctbRcv.GoEnd();
                }*/

                AppendRcvText(builder.ToString());
                UpdateRcvCharDisplay(rcvCharNum);
            }));


            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
        }

        public bool SendMessage(string msg, bool save2file)
        {
            if (msg == null)
            {
                return true;
            }

            if (IsPortOpen())
            {
                try
                {
                    this.Invoke((EventHandler)(delegate
                    {
                        StringBuilder builder = new StringBuilder(msg);
                        builder.Append("\r\n");

                        serialPort.Write(builder.ToString());

                        sendCharNum += msg.Length;
                        labelSend.Text = "s:" + sendCharNum.ToString();

                        //fctbRcv.AppendText(builder.ToString());
                        AppendRcvText(builder.ToString());

                        if (save2file)
                        {
                            //SaveSendLogToFile(msg);
                        }
                    }));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }

            return true;
        }

        private void tsmiThemeLight_Click(object sender, EventArgs e)
        {
            StyleMng.Theme = MetroThemeStyle.Light;
        }

        public static Image GrayReverse(Image img)
        {
            Bitmap bmp = new Bitmap(img);

            Color hide = bmp.GetPixel(0, 0);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    //获取该点的像素的RGB的颜色
                    Color color = bmp.GetPixel(i, j);
                    if (color == hide)
                    {
                        continue;
                    }
                    Color newColor = Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);
                    bmp.SetPixel(i, j, newColor);
                }
            }

            return bmp;
        }

        private void tsmiThemeDark_Click(object sender, EventArgs e)
        {
            StyleMng.Theme = MetroThemeStyle.Dark;

            /*foreach (Control ctl in this.Controls)
            {
                if (ctl is Button)
                {
                    Button btn = ctl as Button;
                    btn.Image = GrayReverse(btn.Image);
                    //btn.FlatAppearance.MouseOverBackColor = style;
                }
            }*/
            /*btNew.Image     = GrayReverse(btNew.Image);
            btOpen.Image    = GrayReverse(btOpen.Image);
            btSaveRcv.Image = GrayReverse(btSaveRcv.Image);
            btClear.Image   = GrayReverse(btClear.Image);
            btLine.Image    = GrayReverse(btLine.Image);*/
        }

        private void SetStyleColor(Color style)
        {
            fctbRcv.ServiceLinesColor = style;
            fctbRcv.LineNumberColor = style;
            fctbRcv.SelectionColor = style;
            fctbRcv.BookmarkColor = style;
            fctbRcv.CaretColor = style;

            //panelUpDivide.BackColor = style;
            //panelBottomDivide.BackColor = style;
            btSendSetting.FlatAppearance.BorderColor = style;

            foreach (Control ctl in this.Controls)
            {
                if (ctl is Button)
                {
                    Button btn = ctl as Button;
                    //if (btTopMost != btn)
                    btn.FlatAppearance.MouseOverBackColor = style;
                }
            }
        }

        private void styleSelect_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            for (int i = 0; i <= 14; i++)
            {
                if (item.Text == ((MetroColorStyle)i).ToString())
                {
                    StyleMng.Style = (MetroColorStyle)i;
                    break;
                }
            }

            sendTool.MetroStyle = StyleMng.Style;
            fileSettingForm.MetroStyle = StyleMng.Style;
            portSelectMenu.PortMenuMetroStyle = StyleMng.Style;
            //sentList.PortMenuMetroStyle = metroStyleManager.Style;
            //sentSetting.PortMenuMetroStyle = metroStyleManager.Style;
            styleColor = MetroPaint.GetStyleColor(StyleMng.Style);
            SetStyleColor(styleColor);
        }

        private void btSendSetting_Click(object sender, EventArgs e)
        {
            fileSettingForm.UserShow();
        }

        private void tbSend_ButtonClick(object sender, EventArgs e)
        {
            //SendMessage(tbSend.Text, true);
            sendTool.ShowHide(tbSend);
            //sendTool.Show(tbSend.PointToScreen(new Point(tbSend.Left - 1, tbSend.Height)), tbSend.Width);
        }

        private void tmsiStyleSelect_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripMenuItem parent = (ToolStripMenuItem)sender;
            foreach (ToolStripMenuItem item in parent.DropDownItems)
            {
                item.Checked = false;
            }
            ((ToolStripMenuItem)e.ClickedItem).Checked = true;
        }

        private void tbSend_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SendMessage(tbSend.Text, true);
                    e.Handled = true;
                    break;
                default:
                    break;
            }
        }

        private void sendTBMSave_Click(object sender, EventArgs e)
        {
            sendTool.AddItem(tbSend.Text);
        }

        private long SendTimes = 0;
        private void SendLoopStart()
        {
            //SendTimer.Interval = sentSetting.GetSendPeriod();
            SendTimes = 0;
            SendTimer.Start();
        }
        private void SendLoopStop()
        {
            SendTimer.Stop();
            if (SendTBMLoopChecked)
            {
                SendTBMLoopChecked = false;
            }
        }
        private void sendTBMLoop_Click(object sender, EventArgs e)
        {
            SendTBMLoopChecked = !SendTBMLoopChecked;
            if (SendTBMLoopChecked)
                SendLoopStart();
            else
                SendLoopStop();
        }

        private void sendTBMSendFile_Click(object sender, EventArgs e)
        {
        }

        private void sendTBMSend_Click(object sender, EventArgs e)
        {
            SendMessage(tbSend.Text, true);
        }

        private void SendTimer_Tick(object sender, EventArgs e)
        {
            SendMessage(tbSend.Text, true);
            /*switch (sentSetting.GetSendMode())
            {
                case SendSettingMode.ONCE:
                    SendLoopStop();
                    break;
                case SendSettingMode.REPEAT:
                    SendTimes++;
                    if (SendTimes == sentSetting.GetSendTimes())
                        SendLoopStop();
                    break;
                case SendSettingMode.LOOP:
                    break;
                default:
                    break;
            }*/
            if (!SendTBMLoopChecked)
                SendLoopStop();
        }

        private void btSendFile_Click(object sender, EventArgs e)
        {
            sendTool.Show(tbSend);
        }

        private void btSendMsg_Click(object sender, EventArgs e)
        {
            SendMessage(tbSend.Text, true);
        }

        private void MainForm_LocationChanged(object sender, EventArgs e)
        {
            if (null != sendTool)
                sendTool.UpdateLocation();

            if (null != fctbRcv)
            {
                if (null != fctbRcv.findForm)
                    fctbRcv.findForm.OnLocationChanged();
            }
           
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (null != sendTool)
                sendTool.UpdateLocation();
        }

        private void tsmiHelp_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.Show(this);
        }
    }
}
