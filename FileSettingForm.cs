using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Drawing;
using MetroFramework.Controls;
using System.IO;
using FastColoredTextBoxNS;

namespace TerminalTool
{
    public partial class FileSettingForm : MetroForm
    {
        private MainForm mainForm = null;
        private StreamReader fileSR = null;
        private bool StartSend = false;
        private Color styleColor;
        private int Period = 0;
        private int Times = 0;
        private int FileLineNum = 0;
        private FastColoredTextBox fctb = new FastColoredTextBox();


        public MetroColorStyle MetroStyle
        {
            get { return StyleMng.Style; }
            set
            {
                StyleMng.Style = value;
                labelInfo.BackColor = MetroPaint.GetStyleColor(StyleMng.Style);
                UpdateBtnStyle();
            }
        }


        public FileSettingForm(MainForm form)
        {
            InitializeComponent();

            StyleManager = StyleMng;
            mainForm = form;
            UpdateBtnStyle();
            labelInfo.BackColor = MetroPaint.GetStyleColor(StyleMng.Style);
        }

        public void UserShow()
        {
            if (!this.Visible && null != mainForm)
            {
                Show(mainForm);
            }
        }

        private void UpdateBtnStyle()
        {
            styleColor = MetroPaint.GetStyleColor(StyleMng.Style);
            foreach (Control ctl in this.Controls)
            {
                if (ctl is Button)
                {
                    Button btn = ctl as Button;
                    btn.FlatAppearance.MouseOverBackColor = styleColor;
                    btn.FlatAppearance.BorderColor = styleColor;
                }
            }
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

        private void DisableControl()
        {
            cbLoop.Enabled = false;
            cbShuffle.Enabled = false;
            tbTimes.Enabled = false;
            tbFile.Enabled = false;
            tbSpeed.Enabled = false;
        }

        private void RecoveryControlState()
        {
            cbLoop.Enabled = true;
            cbShuffle.Enabled = true;
            tbTimes.Enabled = true;
            tbFile.Enabled = true;
            tbSpeed.Enabled = true;
        }

        private void tbFile_ButtonClick(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                tbFile.Text = fileDialog.FileName;
            }
        }

        private void NumInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !System.Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                ShowInfo("Please input a digit", ErrorType.ERROR);
            }
        }

        public bool StartFileSend
        {
            get { return StartSend; }
            set
            {
                StartSend = value;
                if (StartSend)
                {
                    DisableControl();
                    btStart.Text = "Stop";
                    StartSendFile();
                }
                else
                {
                    StopSendFile();
                    btStart.Text = "Start";
                    RecoveryControlState();
                }
            }
        }
        private void btStart_Click(object sender, EventArgs e)
        {
            StartFileSend = !StartFileSend;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SendMsg(string msg)
        {
            mainForm.SendMessage(msg, true);
        }

        private int StartSendFile()
        {
            string file = tbFile.Text;

            int.TryParse(tbSpeed.Text, out Period);
            if (0 == Period)
            {
                ShowInfo("Please input a valid Period" + Period.ToString(), ErrorType.ERROR);
                return 0;
            }

            if (null != tbFile.Text && File.Exists(@file))
            {
                FileInfo fileInfo = new FileInfo(file);
                if (fileInfo.Length > 1024*1024)
                {
                    ShowInfo("File overflow 1M!", ErrorType.ERROR);
                }

                bgWorker.RunWorkerAsync(file);
            }
            else
            {
                ShowInfo("File not exist", ErrorType.ERROR);
            }

            return 0;
        }

        private void StopSendFile()
        {
            bgWorker.CancelAsync();
        }

        private bool LoopContinue()
        {
            if (cbLoop.Checked)
            {
                if (null == tbTimes.Text || 0 == tbTimes.Text.Length)
                {
                    return true;
                }
                else
                {
                    int.TryParse(tbTimes.Text, out Times);
                    if (0 == Times)
                    {
                        return false;
                    }
                    Times--;
                    if (Times >= 0)
                    {
                        tbTimes.Text = Times.ToString();
                    }
                    if (Times > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        private int GetRandomNum(int up)
        {
            Random ro = new Random(10);
            long tick = DateTime.Now.Ticks;
            Random ran = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));

            return ran.Next(up);
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int percent;
            int line = 0;
            string output;
            int lineNum;

            BackgroundWorker myWork = sender as BackgroundWorker;
            string file = e.Argument as string;

            do
            {
                if (!File.Exists(@file))
                {
                    e.Cancel = true;
                    return;
                }
                fctb.OpenFile(file, UTF8Encoding.UTF8);
                FileLineNum = fctb.LinesCount;
                line = 0;
                while ((line < FileLineNum) && (!myWork.CancellationPending))
                {
                    if (cbShuffle.Checked)
                        lineNum = GetRandomNum(fctb.LinesCount - 1);
                    else
                        lineNum = 0;
                    output = fctb.GetLineText(lineNum);
                    fctb.RemoveLines(new List<int>() { lineNum });

                    line++;

                    SendMsg(output);

                    percent = (int)(line * 100 / FileLineNum);

                    try
                    {
                        //trigger ProgressChanged event
                        myWork.ReportProgress(percent);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    if (myWork.CancellationPending)
                    {
                        e.Cancel = true;
                    }
                    Thread.Sleep(Period);
                }
            } while (LoopContinue() && (!myWork.CancellationPending));
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //修改进度条的显示。
            this.progressBarSum.Value = e.ProgressPercentage;
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //if (e.Cancelled)
            //{
            //    fileFS.Close();
            //}
            //if (e.)
            //{
            //    fileFS.Close();
            //}
            if (null != fileSR)
                fileSR.Close();
            fileSR = null;
            StartFileSend = false;
            progressBarSum.Value = 0;
        }

        private void FileSettingForm_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void FileSettingForm_Deactivate(object sender, EventArgs e)
        {
            this.Opacity = 0.7;
        }
    }
}
