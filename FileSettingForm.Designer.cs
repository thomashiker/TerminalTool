namespace TerminalTool
{
    partial class FileSettingForm
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
            this.components = new System.ComponentModel.Container();
            this.StyleMng = new MetroFramework.Components.MetroStyleManager(this.components);
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new MetroFramework.Components.MetroToolTip();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbLoop = new MetroFramework.Controls.MetroCheckBox();
            this.btQuit = new MetroFramework.Controls.MetroButton();
            this.btStart = new MetroFramework.Controls.MetroButton();
            this.progressBarSum = new MetroFramework.Controls.MetroProgressBar();
            this.labelInfo = new System.Windows.Forms.Label();
            this.tbSpeed = new MetroFramework.Controls.MetroTextBox();
            this.cbShuffle = new MetroFramework.Controls.MetroCheckBox();
            this.tbFile = new MetroFramework.Controls.MetroTextBox();
            this.tbTimes = new MetroFramework.Controls.MetroTextBox();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.StyleMng)).BeginInit();
            this.SuspendLayout();
            // 
            // StyleMng
            // 
            this.StyleMng.Owner = this;
            // 
            // toolTip
            // 
            this.toolTip.Style = MetroFramework.MetroColorStyle.Default;
            this.toolTip.StyleManager = null;
            this.toolTip.Theme = MetroFramework.MetroThemeStyle.Default;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(8, 52);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(39, 15);
            this.metroLabel1.TabIndex = 64;
            this.metroLabel1.Text = "Speed";
            this.toolTip.SetToolTip(this.metroLabel1, "ms");
            this.metroLabel1.UseStyleColors = true;
            // 
            // cbLoop
            // 
            this.cbLoop.AutoSize = true;
            this.cbLoop.Location = new System.Drawing.Point(227, 52);
            this.cbLoop.Name = "cbLoop";
            this.cbLoop.Size = new System.Drawing.Size(50, 15);
            this.cbLoop.TabIndex = 70;
            this.cbLoop.Text = "Loop";
            this.cbLoop.UseSelectable = true;
            this.cbLoop.UseStyleColors = true;
            // 
            // btQuit
            // 
            this.btQuit.BackColor = System.Drawing.Color.Transparent;
            this.btQuit.Location = new System.Drawing.Point(290, 80);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(50, 22);
            this.btQuit.TabIndex = 69;
            this.btQuit.Text = "&Exit";
            this.btQuit.UseCustomBackColor = true;
            this.btQuit.UseSelectable = true;
            this.btQuit.UseStyleColors = true;
            this.btQuit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.Transparent;
            this.btStart.Location = new System.Drawing.Point(225, 80);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(50, 22);
            this.btStart.TabIndex = 68;
            this.btStart.Text = "Start";
            this.btStart.UseCustomBackColor = true;
            this.btStart.UseSelectable = true;
            this.btStart.UseStyleColors = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // progressBarSum
            // 
            this.progressBarSum.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarSum.FontSize = MetroFramework.MetroProgressBarSize.Small;
            this.progressBarSum.FontWeight = MetroFramework.MetroProgressBarWeight.Bold;
            this.progressBarSum.Location = new System.Drawing.Point(0, 107);
            this.progressBarSum.Name = "progressBarSum";
            this.progressBarSum.Size = new System.Drawing.Size(350, 4);
            this.progressBarSum.Step = 1;
            this.progressBarSum.Style = MetroFramework.MetroColorStyle.Purple;
            this.progressBarSum.TabIndex = 67;
            this.progressBarSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInfo
            // 
            this.labelInfo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.labelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelInfo.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(0, 111);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(350, 16);
            this.labelInfo.TabIndex = 66;
            // 
            // tbSpeed
            // 
            // 
            // 
            // 
            this.tbSpeed.CustomButton.Image = null;
            this.tbSpeed.CustomButton.Location = new System.Drawing.Point(40, 2);
            this.tbSpeed.CustomButton.Name = "";
            this.tbSpeed.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.tbSpeed.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSpeed.CustomButton.TabIndex = 1;
            this.tbSpeed.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSpeed.CustomButton.UseSelectable = true;
            this.tbSpeed.CustomButton.Visible = false;
            this.tbSpeed.DisplayIcon = true;
            this.tbSpeed.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbSpeed.Lines = new string[] {
        "1000"};
            this.tbSpeed.Location = new System.Drawing.Point(48, 48);
            this.tbSpeed.Margin = new System.Windows.Forms.Padding(0);
            this.tbSpeed.MaxLength = 8;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.PasswordChar = '\0';
            this.tbSpeed.PromptText = "ms";
            this.tbSpeed.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSpeed.SelectedText = "";
            this.tbSpeed.SelectionLength = 0;
            this.tbSpeed.SelectionStart = 0;
            this.tbSpeed.ShortcutsEnabled = true;
            this.tbSpeed.ShowClearButton = true;
            this.tbSpeed.Size = new System.Drawing.Size(60, 22);
            this.tbSpeed.TabIndex = 62;
            this.tbSpeed.Text = "1000";
            this.tbSpeed.UseSelectable = true;
            this.tbSpeed.UseStyleColors = true;
            this.tbSpeed.WaterMark = "ms";
            this.tbSpeed.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSpeed.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumInput_KeyPress);
            // 
            // cbShuffle
            // 
            this.cbShuffle.AutoSize = true;
            this.cbShuffle.Location = new System.Drawing.Point(141, 52);
            this.cbShuffle.Name = "cbShuffle";
            this.cbShuffle.Size = new System.Drawing.Size(60, 15);
            this.cbShuffle.TabIndex = 65;
            this.cbShuffle.Text = "Shuffle";
            this.cbShuffle.UseSelectable = true;
            this.cbShuffle.UseStyleColors = true;
            // 
            // tbFile
            // 
            this.tbFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tbFile.CustomButton.Image = global::TerminalTool.Properties.Resources.folder_open;
            this.tbFile.CustomButton.Location = new System.Drawing.Point(310, 2);
            this.tbFile.CustomButton.Name = "";
            this.tbFile.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.tbFile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbFile.CustomButton.TabIndex = 1;
            this.tbFile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbFile.CustomButton.UseSelectable = true;
            this.tbFile.Lines = new string[0];
            this.tbFile.Location = new System.Drawing.Point(11, 17);
            this.tbFile.MaxLength = 32767;
            this.tbFile.Name = "tbFile";
            this.tbFile.PasswordChar = '\0';
            this.tbFile.PromptText = "file path";
            this.tbFile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbFile.SelectedText = "";
            this.tbFile.SelectionLength = 0;
            this.tbFile.SelectionStart = 0;
            this.tbFile.ShortcutsEnabled = true;
            this.tbFile.ShowButton = true;
            this.tbFile.Size = new System.Drawing.Size(330, 22);
            this.tbFile.TabIndex = 61;
            this.tbFile.UseSelectable = true;
            this.tbFile.UseStyleColors = true;
            this.tbFile.WaterMark = "file path";
            this.tbFile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbFile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbFile.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.tbFile_ButtonClick);
            // 
            // tbTimes
            // 
            // 
            // 
            // 
            this.tbTimes.CustomButton.Image = null;
            this.tbTimes.CustomButton.Location = new System.Drawing.Point(42, 2);
            this.tbTimes.CustomButton.Name = "";
            this.tbTimes.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.tbTimes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTimes.CustomButton.TabIndex = 1;
            this.tbTimes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTimes.CustomButton.UseSelectable = true;
            this.tbTimes.CustomButton.Visible = false;
            this.tbTimes.DisplayIcon = true;
            this.tbTimes.Lines = new string[0];
            this.tbTimes.Location = new System.Drawing.Point(279, 48);
            this.tbTimes.MaxLength = 8;
            this.tbTimes.Name = "tbTimes";
            this.tbTimes.PasswordChar = '\0';
            this.tbTimes.PromptText = "limitless";
            this.tbTimes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTimes.SelectedText = "";
            this.tbTimes.SelectionLength = 0;
            this.tbTimes.SelectionStart = 0;
            this.tbTimes.ShortcutsEnabled = true;
            this.tbTimes.ShowClearButton = true;
            this.tbTimes.Size = new System.Drawing.Size(62, 22);
            this.tbTimes.TabIndex = 63;
            this.tbTimes.UseSelectable = true;
            this.tbTimes.UseStyleColors = true;
            this.tbTimes.WaterMark = "limitless";
            this.tbTimes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTimes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbTimes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumInput_KeyPress);
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // FileSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 127);
            this.ControlBox = false;
            this.Controls.Add(this.cbLoop);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.progressBarSum);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.cbShuffle);
            this.Controls.Add(this.tbFile);
            this.Controls.Add(this.tbTimes);
            this.DisplayHeader = false;
            this.Name = "FileSettingForm";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FileSettingForm";
            this.Activated += new System.EventHandler(this.FileSettingForm_Activated);
            this.Deactivate += new System.EventHandler(this.FileSettingForm_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.StyleMng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager StyleMng;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private MetroFramework.Components.MetroToolTip toolTip;
        private MetroFramework.Controls.MetroCheckBox cbLoop;
        private MetroFramework.Controls.MetroButton btQuit;
        private MetroFramework.Controls.MetroButton btStart;
        private MetroFramework.Controls.MetroProgressBar progressBarSum;
        private System.Windows.Forms.Label labelInfo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbSpeed;
        private MetroFramework.Controls.MetroCheckBox cbShuffle;
        private MetroFramework.Controls.MetroTextBox tbFile;
        private MetroFramework.Controls.MetroTextBox tbTimes;
        private System.ComponentModel.BackgroundWorker bgWorker;
    }
}