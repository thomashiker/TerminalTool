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
using System.Threading;
using System.Runtime.InteropServices;

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
        private Color styleColor;
        private bool recordState = true;
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
            this.StyleManager = StyleMng;

            sendTool = new SendToolForm(this, tbSend);
            fileSettingForm = new FileSettingForm(this);

            /*user init*/
            styleColor = MetroPaint.GetStyleColor(this.Style);
            SetStyleColor(styleColor);
            trackBarZoomInit();
            portSelectMenu.Closing += new ToolStripDropDownClosingEventHandler(portSettingContextMenu_closed);
            SavedLogPath = System.Environment.CurrentDirectory;
            FCTBAutoScroll = true;

            // 打开控件的双缓冲
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
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

        private void AppendRcvText(string msg)
        {
            LogToFile(msg);

            /*this.BeginInvoke((MethodInvoker)delegate ()
            {
                fctbRcv.BeginUpdate();
                fctbRcv.AppendText(msg);
                if (fctbRcvAutoScroll)
                {
                    //fctbRcv.GoEnd();
                    fctbRcv.GoEndLine();
                }
                fctbRcv.EndUpdate();
            });*/
            BeginInvoke(new Action(() =>
            {
                fctbRcv.BeginUpdate();
                fctbRcv.AppendText(msg);
                if (fctbRcvAutoScroll)
                {
                    //fctbRcv.GoEnd();
                    fctbRcv.GoEndLine();
                }
                fctbRcv.EndUpdate();
            }));
        }
        public delegate void WriteText(string msg);
        public void WriteReceiveText(String msg)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new WriteText(WriteReceiveText), msg);
                return;
            }
            //fctbRcv.BeginUpdate();
            fctbRcv.AppendText(msg);
            if (fctbRcvAutoScroll)
            {
                //fctbRcv.GoEnd();
                fctbRcv.GoEndLine();
            }
            //fctbRcv.EndUpdate();
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

        public bool IsPortOpen()
        {
            return serialPort.IsOpen;
        }

        private void PortStateUpdate()
        {
            if (IsPortOpen())
            {
                tSBConnect.Image = global::TerminalTool.Properties.Resources.connect;
                labelConnect.Text = GetPortSetting();
                //labelConnect.Font = new Font(labelConnect.Font, FontStyle.Regular);
                //labelConnect.ForeColor = Color.Green;
                labelConnect.UseCustomForeColor = false;

                LinkTimer.Start();
            }
            else
            {
                tSBConnect.Image = global::TerminalTool.Properties.Resources.connection_error;
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


        public bool FCTBAutoScroll
        {
            get { return fctbRcvAutoScroll; }
            set
            {
                fctbRcvAutoScroll = value;
            }
        }

        private void tSBNew_Click(object sender, EventArgs e)
        {
            ToolStripButton item = sender as ToolStripButton;
            portSelectMenu.Show(this, new Point(item.Owner.Left, item.Owner.Bottom));
        }

        private void tSBConnect_Click(object sender, EventArgs e)
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

        private void tSBSave_Click(object sender, EventArgs e)
        {
            SaveToFileAs();
        }

        private void ClearReceive()
        {
            fctbRcv.Clear();
            rcvCharNum = 0;
        }
        private void tSBClear_Click(object sender, EventArgs e)
        {
            ClearReceive();
        }

        private void tSBShowLineNum_Click(object sender, EventArgs e)
        {
            fctbRcv.ShowLineNumbers = !fctbRcv.ShowLineNumbers;
            if (!fctbRcv.ShowLineNumbers)
            {
                fctbRcv.Bookmarks.Clear();
            }
        }

        private void tSBClearTags_Click(object sender, EventArgs e)
        {
            //fctbRcv.Bookmarks.Clear();
            int line = 0;
            while (line < fctbRcv.LinesCount)
            {
                fctbRcv.Bookmarks.Remove(line);
                line++;
            }
        }

        private void tSBRecord_Click(object sender, EventArgs e)
        {
            recordState = !recordState;
            if (recordState)
            {
                tSBRecord.Image = global::TerminalTool.Properties.Resources.MD_record; //toolStripimageList.Images[11];
                tSBRecord.ToolTipText = "Record";
            }
            else
            {
                tSBRecord.Image = global::TerminalTool.Properties.Resources.MD_stop;//toolStripimageList.Images[12];
                tSBRecord.ToolTipText = "Stop Record";
            }
        }

        private void tSBNewLogFile_Click(object sender, EventArgs e)
        {
            CreateLogFile();
        }

        private void tSBOpenLog_Click(object sender, EventArgs e)
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

        private void tSBOpenLogDir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("Explorer.exe");
            psi.Arguments = "/e,/select," + SavedLogPath;
            System.Diagnostics.Process.Start(psi);
        }

        private void tSBGoBackward_Click(object sender, EventArgs e)
        {
            fctbRcv.NavigateBackward();
        }

        private void tSBGoForward_Click(object sender, EventArgs e)
        {
            fctbRcv.NavigateForward();
        }

        private void tSBScreenShot_Click(object sender, EventArgs e)
        {
            CaptureImageTool capture = new CaptureImageTool();

            capture.SelectCursor = Cursors.Default;
            capture.DrawCursor = Cursors.Default;
            if (capture.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void tSBSetting_Click(object sender, EventArgs e)
        {
            cmSys.Show(ToolStrip, tSBSetting.Bounds.Left, tSBSetting.Bounds.Bottom);
        }

        private void tSBAutoScroll_Click(object sender, EventArgs e)
        {
            FCTBAutoScroll = !FCTBAutoScroll;
        }

        private void tSBTopMost_Click(object sender, EventArgs e)
        {
            TopMost = tSBTopMost.Checked;
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
                    //StringBuilder sendMsgBuilder = new StringBuilder(MsgToSend);
                    SendMessage(MsgToSend, true);
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

        private void UpdateLinkTimeDisplay(Int64 time)
        {
            Int64 seconds;
            Int64 hours;
            Int64 minutes;

            /*labelTime.Invoke((EventHandler)(delegate
            {
                seconds = time % 60;
                hours = time / 60;
                minutes = (hours) % 60;
                hours = hours / 60;
                labelTime.Text = hours.ToString().PadLeft(2, '0') + ":" + minutes.ToString().PadLeft(2, '0') + ":" + seconds.ToString().PadLeft(2, '0');
            }));*/
            labelTime.BeginInvoke((MethodInvoker)delegate ()
            {
                seconds = time % 60;
                hours = time / 60;
                minutes = (hours) % 60;
                hours = hours / 60;
                labelTime.Text = hours.ToString().PadLeft(2, '0') + ":" + minutes.ToString().PadLeft(2, '0') + ":" + seconds.ToString().PadLeft(2, '0');
            });
        }

        private void LinkTimer_Tick(object sender, EventArgs e)
        {
            TimeElapse++;
            UpdateLinkTimeDisplay(TimeElapse);
        }

        private void UpdateRcvCharDisplay(Int64 num)
        {
            /*this.BeginInvoke((MethodInvoker)delegate ()
            {
                labelRcv.Text = "r:" + num.ToString();
            });*/
            BeginInvoke(new Action(() =>
            {
                labelRcv.Text = "r:" + num.ToString();
            }));
        }
        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int n;
            n = serialPort.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致  
            byte[] buf = new byte[n];//声明一个临时数组存储当前来的串口数据
            string rcvdata;
            rcvCharNum += n;//增加接收计数  
            serialPort.Read(buf, 0, n); ;//读取缓冲数据
            
            //因为要访问ui资源，所以需要使用invoke方式同步ui。 
            rcvdata = Encoding.Default.GetString(buf);
            AppendRcvText(rcvdata);
            //WriteReceiveText(rcvdata);
            UpdateRcvCharDisplay(rcvCharNum);

            Thread.Sleep(50);
            Application.DoEvents();

            //serialPort.DiscardInBuffer();
            //serialPort.ReadExisting
            //SerialPort sp = (SerialPort)sender;
            //string indata = sp.ReadExisting();

           //while ((n = serialPort.BytesToRead) > 0)
           //{
           //    byte[] buf = new byte[n];//声明一个临时数组存储当前来的串口数据
           //    string rcvdata;
           //    rcvCharNum += n;//增加接收计数  
           //    serialPort.Read(buf, 0, n); ;//读取缓冲数据
           //
           //    //因为要访问ui资源，所以需要使用invoke方式同步ui。 
           //    rcvdata = Encoding.Default.GetString(buf);
           //    AppendRcvText(rcvdata);
           //    UpdateRcvCharDisplay(rcvCharNum);
           //
           //    Application.DoEvents();
           //}
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
                        builder.Append("\n");

                        serialPort.Write(builder.ToString());

                        sendCharNum += msg.Length;
                        labelSend.Text = "s:" + sendCharNum.ToString();

                        //fctbRcv.AppendText(builder.ToString());
                        //AppendRcvText(builder.ToString());

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
            ToolStrip.ItemSelectedColor = style;
            ToolStrip.CheckedItemColor = style;
            ToolStrip.CheckPressItemColors = style;
            ToolStrip.ItemPressedColors = style;
            ToolStrip.Refresh();

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
                    this.UpdateWindowButtonsStyle();
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
            sendTool.AddCmd(tbSend.Text);
        }

        private void sendTBMSend_Click(object sender, EventArgs e)
        {
            SendMessage(tbSend.Text, true);
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
            this.Update();
        }

        private void tsmiHelp_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.MetroStyle = StyleMng.Style;
            help.Show(this);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (fctbRcv.SelectedText.Equals(""))
            //    return;
            //Clipboard.SetDataObject(fctbRcv.SelectedText, true);
            fctbRcv.Copy();
        }

        private void copyAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(fctbRcv.Text, true);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearReceive();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tSBConnect_Click(sender, e);
        }

        private void bColoerBlackItem_Click(object sender, EventArgs e)
        {
            fctbRcv.BackColor = Color.Black;
            fctbRcv.IndentBackColor = Color.Black;
            fctbRcv.ForeColor = Color.White;
        }

        private void bColoerWhiteItem_Click(object sender, EventArgs e)
        {
            fctbRcv.BackColor = Color.White;
            fctbRcv.IndentBackColor = Color.White;
            fctbRcv.ForeColor = Color.Black;
        }

        private void bColoerGrayItem_Click(object sender, EventArgs e)
        {
            fctbRcv.BackColor = Color.WhiteSmoke;
            fctbRcv.IndentBackColor = Color.WhiteSmoke;
            fctbRcv.ForeColor = Color.Black;
        }



        // usb消息定义
        public const int WM_DEVICE_CHANGE = 0x219;
        public const int DBT_DEVICEARRIVAL = 0x8000;
        public const int DBT_DEVICE_REMOVE_COMPLETE = 0x8004;
        public const UInt32 DBT_DEVTYP_PORT = 0x00000003;

        //[StructLayout(LayoutKind.Sequential)]
        struct DEV_BROADCAST_HDR
        {
            public UInt32 dbch_size;
            public UInt32 dbch_devicetype;
            public UInt32 dbch_reserved;
        }


        //[StructLayout(LayoutKind.Sequential)]
        protected struct DEV_BROADCAST_PORT_Fixed
        {
            public uint dbcp_size;
            public uint dbcp_devicetype;
            public uint dbcp_reserved;
            // Variable?length field dbcp_name is declared here in the C header file.
        }


        /// <summary>
        /// 检测USB串口的拔插
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_DEVICE_CHANGE)        // 捕获USB设备的拔出消息WM_DEVICECHANGE
            {
                DEV_BROADCAST_HDR dbhdr;
                switch (m.WParam.ToInt32())
                {
                    case DBT_DEVICE_REMOVE_COMPLETE:    // USB拔出     
                        dbhdr = (DEV_BROADCAST_HDR)Marshal.PtrToStructure(m.LParam, typeof(DEV_BROADCAST_HDR));
                        if (dbhdr.dbch_devicetype == DBT_DEVTYP_PORT)
                        {
                            string portName = Marshal.PtrToStringUni((IntPtr)(m.LParam.ToInt32() + Marshal.SizeOf(typeof(DEV_BROADCAST_PORT_Fixed))));
                            fctbRcv.AppendText(portName + " removed\n");
                        }
                        break;
                    case DBT_DEVICEARRIVAL:             // USB插入获取对应串口名称
                        dbhdr = (DEV_BROADCAST_HDR)Marshal.PtrToStructure(m.LParam, typeof(DEV_BROADCAST_HDR));
                        if (dbhdr.dbch_devicetype == DBT_DEVTYP_PORT)
                        {
                            string portName = Marshal.PtrToStringUni((IntPtr)(m.LParam.ToInt32() + Marshal.SizeOf(typeof(DEV_BROADCAST_PORT_Fixed))));
                            fctbRcv.AppendText(portName + " inserted\n");
                        }
                        break;
                }
            }
            base.WndProc(ref m);
        }
    }
}
