﻿namespace TerminalTool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelConnect = new MetroFramework.Controls.MetroLabel();
            this.labelRcv = new MetroFramework.Controls.MetroLabel();
            this.labelSend = new MetroFramework.Controls.MetroLabel();
            this.labelTime = new MetroFramework.Controls.MetroLabel();
            this.cmSys = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.tsmiBackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiStyleSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.styleDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.styleBlack = new System.Windows.Forms.ToolStripMenuItem();
            this.styleWhite = new System.Windows.Forms.ToolStripMenuItem();
            this.styleSilver = new System.Windows.Forms.ToolStripMenuItem();
            this.styleBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.styleGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.styleLime = new System.Windows.Forms.ToolStripMenuItem();
            this.styleTeal = new System.Windows.Forms.ToolStripMenuItem();
            this.styleOrange = new System.Windows.Forms.ToolStripMenuItem();
            this.styleBrown = new System.Windows.Forms.ToolStripMenuItem();
            this.stylePink = new System.Windows.Forms.ToolStripMenuItem();
            this.styleMagenta = new System.Windows.Forms.ToolStripMenuItem();
            this.stylePurple = new System.Windows.Forms.ToolStripMenuItem();
            this.styleRed = new System.Windows.Forms.ToolStripMenuItem();
            this.styleYellow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSystemSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.cmSend = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.sendTBMSave = new System.Windows.Forms.ToolStripMenuItem();
            this.sendTBMLoop = new System.Windows.Forms.ToolStripMenuItem();
            this.sendTBMSelectScript = new System.Windows.Forms.ToolStripMenuItem();
            this.sendTBMSend = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBarZoom = new MetroFramework.Controls.MetroTrackBar();
            this.linkZoom = new MetroFramework.Controls.MetroLink();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.menuToolTip = new MetroFramework.Components.MetroToolTip();
            this.btSendSetting = new System.Windows.Forms.Button();
            this.LinkTimer = new System.Windows.Forms.Timer(this.components);
            this.StyleMng = new MetroFramework.Components.MetroStyleManager(this.components);
            this.SendTimer = new System.Windows.Forms.Timer(this.components);
            this.btSendMsg = new MetroFramework.Controls.MetroButton();
            this.fctbRcv = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbSend = new MetroFramework.Controls.MetroTextBox();
            this.ToolStrip = new Antiufo.Controls.MetroToolStrip();
            this.tSBNew = new System.Windows.Forms.ToolStripButton();
            this.tSBConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBSave = new System.Windows.Forms.ToolStripButton();
            this.tSBClear = new System.Windows.Forms.ToolStripButton();
            this.tSBShowLineNum = new System.Windows.Forms.ToolStripButton();
            this.tSBClearTags = new System.Windows.Forms.ToolStripButton();
            this.tSBRecord = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBNewLogFile = new System.Windows.Forms.ToolStripButton();
            this.tSBOpenLog = new System.Windows.Forms.ToolStripButton();
            this.tSBOpenLogDir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBFindPrevious = new System.Windows.Forms.ToolStripButton();
            this.tSBFindNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tSBScreenShot = new System.Windows.Forms.ToolStripButton();
            this.tSBAutoScroll = new System.Windows.Forms.ToolStripButton();
            this.tSBTopMost = new System.Windows.Forms.ToolStripButton();
            this.toolMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.copyAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmSys.SuspendLayout();
            this.cmSend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StyleMng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fctbRcv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ToolStrip.SuspendLayout();
            this.toolMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelConnect
            // 
            this.labelConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelConnect.AutoSize = true;
            this.labelConnect.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelConnect.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelConnect.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelConnect.Location = new System.Drawing.Point(6, 384);
            this.labelConnect.Name = "labelConnect";
            this.labelConnect.Size = new System.Drawing.Size(89, 15);
            this.labelConnect.TabIndex = 1;
            this.labelConnect.Text = "No Connection";
            this.labelConnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelConnect.UseStyleColors = true;
            // 
            // labelRcv
            // 
            this.labelRcv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRcv.AutoSize = true;
            this.labelRcv.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelRcv.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelRcv.Location = new System.Drawing.Point(202, 384);
            this.labelRcv.Name = "labelRcv";
            this.labelRcv.Size = new System.Drawing.Size(22, 15);
            this.labelRcv.TabIndex = 2;
            this.labelRcv.Text = "r:0";
            this.labelRcv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRcv.UseStyleColors = true;
            // 
            // labelSend
            // 
            this.labelSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSend.AutoSize = true;
            this.labelSend.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelSend.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelSend.Location = new System.Drawing.Point(271, 384);
            this.labelSend.Name = "labelSend";
            this.labelSend.Size = new System.Drawing.Size(22, 15);
            this.labelSend.TabIndex = 3;
            this.labelSend.Text = "s:0";
            this.labelSend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSend.UseStyleColors = true;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelTime.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelTime.Location = new System.Drawing.Point(334, 384);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(55, 15);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "00:00:00";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTime.UseStyleColors = true;
            this.labelTime.WrapToLine = true;
            // 
            // cmSys
            // 
            this.cmSys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmSys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmSys.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBackColor,
            this.tmsiStyleSelect,
            this.toolStripSeparator2,
            this.tsmiSystemSetting,
            this.tsmiHelp});
            this.cmSys.Name = "metroContextMenu1";
            this.cmSys.Size = new System.Drawing.Size(141, 98);
            this.cmSys.UseStyleColors = true;
            // 
            // tsmiBackColor
            // 
            this.tsmiBackColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.whiteToolStripMenuItem,
            this.grayToolStripMenuItem,
            this.customizeToolStripMenuItem});
            this.tsmiBackColor.Name = "tsmiBackColor";
            this.tsmiBackColor.Size = new System.Drawing.Size(140, 22);
            this.tsmiBackColor.Text = "&Back Color";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem1.Text = "&Black";
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.whiteToolStripMenuItem.Text = "&White";
            // 
            // grayToolStripMenuItem
            // 
            this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            this.grayToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.grayToolStripMenuItem.Text = "&Gray";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // tmsiStyleSelect
            // 
            this.tmsiStyleSelect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.styleDefault,
            this.styleBlack,
            this.styleWhite,
            this.styleSilver,
            this.styleBlue,
            this.styleGreen,
            this.styleLime,
            this.styleTeal,
            this.styleOrange,
            this.styleBrown,
            this.stylePink,
            this.styleMagenta,
            this.stylePurple,
            this.styleRed,
            this.styleYellow});
            this.tmsiStyleSelect.Name = "tmsiStyleSelect";
            this.tmsiStyleSelect.Size = new System.Drawing.Size(140, 22);
            this.tmsiStyleSelect.Text = "&Style";
            this.tmsiStyleSelect.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tmsiStyleSelect_DropDownItemClicked);
            // 
            // styleDefault
            // 
            this.styleDefault.Name = "styleDefault";
            this.styleDefault.Size = new System.Drawing.Size(128, 22);
            this.styleDefault.Text = "Default";
            this.styleDefault.Click += new System.EventHandler(this.styleSelect_Click);
            // 
            // styleBlack
            // 
            this.styleBlack.Name = "styleBlack";
            this.styleBlack.Size = new System.Drawing.Size(128, 22);
            this.styleBlack.Text = "Black";
            this.styleBlack.Click += new System.EventHandler(this.styleSelect_Click);
            // 
            // styleWhite
            // 
            this.styleWhite.Name = "styleWhite";
            this.styleWhite.Size = new System.Drawing.Size(128, 22);
            this.styleWhite.Text = "White";
            this.styleWhite.Click += new System.EventHandler(this.styleSelect_Click);
            // 
            // styleSilver
            // 
            this.styleSilver.Name = "styleSilver";
            this.styleSilver.Size = new System.Drawing.Size(128, 22);
            this.styleSilver.Text = "Silver";
            this.styleSilver.Click += new System.EventHandler(this.styleSelect_Click);
            // 
            // styleBlue
            // 
            this.styleBlue.Name = "styleBlue";
            this.styleBlue.Size = new System.Drawing.Size(128, 22);
            this.styleBlue.Text = "Blue";
            this.styleBlue.Click += new System.EventHandler(this.styleSelect_Click);
            // 
            // styleGreen
            // 
            this.styleGreen.Name = "styleGreen";
            this.styleGreen.Size = new System.Drawing.Size(128, 22);
            this.styleGreen.Text = "Green";
            this.styleGreen.Click += new System.EventHandler(this.styleSelect_Click);
            // 
            // styleLime
            // 
            this.styleLime.Name = "styleLime";
            this.styleLime.Size = new System.Drawing.Size(128, 22);
            this.styleLime.Text = "Lime";
            this.styleLime.Click += new System.EventHandler(this.styleSelect_Click);
            // 
            // styleTeal
            // 
            this.styleTeal.Name = "styleTeal";
            this.styleTeal.Size = new System.Drawing.Size(128, 22);
            this.styleTeal.Text = "Teal";
            this.styleTeal.Click += new System.EventHandler(this.styleSelect_Click);
            // 
            // styleOrange
            // 
            this.styleOrange.Name = "styleOrange";
            this.styleOrange.Size = new System.Drawing.Size(128, 22);
            this.styleOrange.Text = "Orange";
            this.styleOrange.Click += new System.EventHandler(this.styleSelect_Click);
            // 
            // styleBrown
            // 
            this.styleBrown.Name = "styleBrown";
            this.styleBrown.Size = new System.Drawing.Size(128, 22);
            this.styleBrown.Text = "Brown";
            this.styleBrown.Click += new System.EventHandler(this.styleSelect_Click);
            // 
            // stylePink
            // 
            this.stylePink.Name = "stylePink";
            this.stylePink.Size = new System.Drawing.Size(128, 22);
            this.stylePink.Text = "Pink";
            this.stylePink.Click += new System.EventHandler(this.styleSelect_Click);
            // 
            // styleMagenta
            // 
            this.styleMagenta.Name = "styleMagenta";
            this.styleMagenta.Size = new System.Drawing.Size(128, 22);
            this.styleMagenta.Text = "Magenta";
            this.styleMagenta.Click += new System.EventHandler(this.styleSelect_Click);
            // 
            // stylePurple
            // 
            this.stylePurple.Name = "stylePurple";
            this.stylePurple.Size = new System.Drawing.Size(128, 22);
            this.stylePurple.Text = "Purple";
            this.stylePurple.Click += new System.EventHandler(this.styleSelect_Click);
            // 
            // styleRed
            // 
            this.styleRed.Name = "styleRed";
            this.styleRed.Size = new System.Drawing.Size(128, 22);
            this.styleRed.Text = "Red";
            this.styleRed.Click += new System.EventHandler(this.styleSelect_Click);
            // 
            // styleYellow
            // 
            this.styleYellow.Name = "styleYellow";
            this.styleYellow.Size = new System.Drawing.Size(128, 22);
            this.styleYellow.Text = "Yellow";
            this.styleYellow.Click += new System.EventHandler(this.styleSelect_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(137, 6);
            // 
            // tsmiSystemSetting
            // 
            this.tsmiSystemSetting.Name = "tsmiSystemSetting";
            this.tsmiSystemSetting.Size = new System.Drawing.Size(140, 22);
            this.tsmiSystemSetting.Text = "&Setting";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(140, 22);
            this.tsmiHelp.Text = "&Help";
            this.tsmiHelp.Click += new System.EventHandler(this.tsmiHelp_Click);
            // 
            // cmSend
            // 
            this.cmSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmSend.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendTBMSave,
            this.sendTBMLoop,
            this.sendTBMSelectScript,
            this.sendTBMSend});
            this.cmSend.Name = "metroContextMenu1";
            this.cmSend.Size = new System.Drawing.Size(110, 92);
            this.cmSend.UseStyleColors = true;
            // 
            // sendTBMSave
            // 
            this.sendTBMSave.Name = "sendTBMSave";
            this.sendTBMSave.Size = new System.Drawing.Size(109, 22);
            this.sendTBMSave.Text = "&Save";
            this.sendTBMSave.Click += new System.EventHandler(this.sendTBMSave_Click);
            // 
            // sendTBMLoop
            // 
            this.sendTBMLoop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sendTBMLoop.Image = global::TerminalTool.Properties.Resources.arrow_3_down_right;
            this.sendTBMLoop.Name = "sendTBMLoop";
            this.sendTBMLoop.Size = new System.Drawing.Size(109, 22);
            this.sendTBMLoop.Tag = "true";
            this.sendTBMLoop.Text = "Loop";
            this.sendTBMLoop.Click += new System.EventHandler(this.sendTBMLoop_Click);
            // 
            // sendTBMSelectScript
            // 
            this.sendTBMSelectScript.Name = "sendTBMSelectScript";
            this.sendTBMSelectScript.Size = new System.Drawing.Size(109, 22);
            this.sendTBMSelectScript.Text = "Script";
            // 
            // sendTBMSend
            // 
            this.sendTBMSend.Name = "sendTBMSend";
            this.sendTBMSend.Size = new System.Drawing.Size(109, 22);
            this.sendTBMSend.Text = "Send";
            this.sendTBMSend.Click += new System.EventHandler(this.sendTBMSend_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(412, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 10);
            this.panel1.TabIndex = 50;
            // 
            // trackBarZoom
            // 
            this.trackBarZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarZoom.BackColor = System.Drawing.Color.Transparent;
            this.trackBarZoom.LargeChange = 10;
            this.trackBarZoom.Location = new System.Drawing.Point(426, 385);
            this.trackBarZoom.Maximum = 140;
            this.trackBarZoom.Name = "trackBarZoom";
            this.trackBarZoom.Size = new System.Drawing.Size(50, 12);
            this.trackBarZoom.SmallChange = 10;
            this.trackBarZoom.TabIndex = 69;
            this.trackBarZoom.Text = "metroTrackBar";
            this.trackBarZoom.Value = 40;
            this.trackBarZoom.ValueChanged += new System.EventHandler(this.trackBarZoom_ValueChanged);
            // 
            // linkZoom
            // 
            this.linkZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkZoom.Location = new System.Drawing.Point(390, 384);
            this.linkZoom.Name = "linkZoom";
            this.linkZoom.Size = new System.Drawing.Size(38, 15);
            this.linkZoom.TabIndex = 71;
            this.linkZoom.Text = "100%";
            this.linkZoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkZoom.UseSelectable = true;
            this.linkZoom.UseStyleColors = true;
            this.linkZoom.Click += new System.EventHandler(this.linkZoom_Click);
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM3";
            this.serialPort.ReadBufferSize = 8192;
            this.serialPort.WriteBufferSize = 4096;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // menuToolTip
            // 
            this.menuToolTip.StripAmpersands = true;
            this.menuToolTip.Style = MetroFramework.MetroColorStyle.Default;
            this.menuToolTip.StyleManager = null;
            this.menuToolTip.Theme = MetroFramework.MetroThemeStyle.Default;
            // 
            // btSendSetting
            // 
            this.btSendSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSendSetting.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btSendSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btSendSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSendSetting.Image = global::TerminalTool.Properties.Resources.ftp;
            this.btSendSetting.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSendSetting.Location = new System.Drawing.Point(474, 359);
            this.btSendSetting.Margin = new System.Windows.Forms.Padding(2);
            this.btSendSetting.Name = "btSendSetting";
            this.btSendSetting.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btSendSetting.Size = new System.Drawing.Size(22, 22);
            this.btSendSetting.TabIndex = 47;
            this.menuToolTip.SetToolTip(this.btSendSetting, "Send File");
            this.btSendSetting.UseVisualStyleBackColor = true;
            this.btSendSetting.Click += new System.EventHandler(this.btSendSetting_Click);
            // 
            // LinkTimer
            // 
            this.LinkTimer.Interval = 1000;
            this.LinkTimer.Tick += new System.EventHandler(this.LinkTimer_Tick);
            // 
            // StyleMng
            // 
            this.StyleMng.Owner = this;
            // 
            // SendTimer
            // 
            this.SendTimer.Interval = 1000;
            this.SendTimer.Tick += new System.EventHandler(this.SendTimer_Tick);
            // 
            // btSendMsg
            // 
            this.btSendMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSendMsg.Location = new System.Drawing.Point(436, 359);
            this.btSendMsg.Margin = new System.Windows.Forms.Padding(0);
            this.btSendMsg.Name = "btSendMsg";
            this.btSendMsg.Size = new System.Drawing.Size(35, 22);
            this.btSendMsg.TabIndex = 75;
            this.btSendMsg.Text = "Send";
            this.btSendMsg.UseCustomBackColor = true;
            this.btSendMsg.UseSelectable = true;
            this.btSendMsg.UseStyleColors = true;
            this.btSendMsg.Click += new System.EventHandler(this.btSendMsg_Click);
            // 
            // fctbRcv
            // 
            this.fctbRcv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fctbRcv.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctbRcv.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fctbRcv.BackBrush = null;
            this.fctbRcv.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fctbRcv.BookmarkColor = System.Drawing.Color.RoyalBlue;
            this.fctbRcv.CaretColor = System.Drawing.Color.MediumSeaGreen;
            this.fctbRcv.CharHeight = 14;
            this.fctbRcv.CharWidth = 8;
            this.fctbRcv.ContextMenuStrip = this.toolMenu;
            this.fctbRcv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbRcv.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbRcv.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fctbRcv.IndentBackColor = System.Drawing.Color.White;
            this.fctbRcv.IsReplaceMode = false;
            this.fctbRcv.Location = new System.Drawing.Point(1, 56);
            this.fctbRcv.Margin = new System.Windows.Forms.Padding(0);
            this.fctbRcv.Name = "fctbRcv";
            this.fctbRcv.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbRcv.ReadOnly = true;
            this.fctbRcv.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbRcv.ServiceColors = null;
            this.fctbRcv.ServiceLinesColor = System.Drawing.Color.DeepSkyBlue;
            this.fctbRcv.Size = new System.Drawing.Size(498, 300);
            this.fctbRcv.TabIndex = 0;
            this.fctbRcv.WordWrapAutoIndent = false;
            this.fctbRcv.WordWrapMode = FastColoredTextBoxNS.WordWrapMode.Custom;
            this.fctbRcv.Zoom = 100;
            this.fctbRcv.KeyPressed += new System.Windows.Forms.KeyPressEventHandler(this.fctbRcv_KeyPressed);
            this.fctbRcv.ZoomChanged += new System.EventHandler(this.fctbRcv_ZoomChanged);
            this.fctbRcv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fctbRcv_KeyDown);
            this.fctbRcv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fctbRcv_KeyPress);
            this.fctbRcv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fctbRcv_MouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.cmSys;
            this.pictureBox1.Image = global::TerminalTool.Properties.Resources.terminal;
            this.pictureBox1.Location = new System.Drawing.Point(4, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // tbSend
            // 
            this.tbSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSend.ContextMenuStrip = this.cmSend;
            // 
            // 
            // 
            this.tbSend.CustomButton.FlatAppearance.BorderSize = 0;
            this.tbSend.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbSend.CustomButton.Font = new System.Drawing.Font("Wingdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.tbSend.CustomButton.Image = global::TerminalTool.Properties.Resources.arrow_7_down;
            this.tbSend.CustomButton.Location = new System.Drawing.Point(415, 2);
            this.tbSend.CustomButton.Margin = new System.Windows.Forms.Padding(0);
            this.tbSend.CustomButton.Name = "";
            this.tbSend.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.tbSend.CustomButton.Style = MetroFramework.MetroColorStyle.Lime;
            this.tbSend.CustomButton.TabIndex = 1;
            this.tbSend.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSend.CustomButton.UseSelectable = true;
            this.tbSend.CustomButton.UseStyleColors = true;
            this.tbSend.DisplayIcon = true;
            this.tbSend.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.tbSend.Icon = global::TerminalTool.Properties.Resources.mail_inbox;
            this.tbSend.Lines = new string[0];
            this.tbSend.Location = new System.Drawing.Point(2, 359);
            this.tbSend.MaxLength = 32767;
            this.tbSend.Name = "tbSend";
            this.tbSend.PasswordChar = '\0';
            this.tbSend.PromptText = "send...";
            this.tbSend.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSend.SelectedText = "";
            this.tbSend.SelectionLength = 0;
            this.tbSend.SelectionStart = 0;
            this.tbSend.ShortcutsEnabled = true;
            this.tbSend.ShowButton = true;
            this.tbSend.ShowClearButton = true;
            this.tbSend.Size = new System.Drawing.Size(435, 22);
            this.tbSend.TabIndex = 48;
            this.tbSend.UseSelectable = true;
            this.tbSend.UseStyleColors = true;
            this.tbSend.WaterMark = "send...";
            this.tbSend.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSend.WaterMarkFont = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSend.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.tbSend_ButtonClick);
            this.tbSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSend_KeyDown);
            // 
            // ToolStrip
            // 
            this.ToolStrip.CanOverflow = false;
            this.ToolStrip.CheckedItemColor = System.Drawing.Color.Chocolate;
            this.ToolStrip.CheckPressItemColors = System.Drawing.Color.Chocolate;
            this.ToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.ItemPressedColors = System.Drawing.Color.Chocolate;
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSBNew,
            this.tSBConnect,
            this.toolStripSeparator1,
            this.tSBSave,
            this.tSBClear,
            this.tSBShowLineNum,
            this.tSBClearTags,
            this.tSBRecord,
            this.toolStripSeparator3,
            this.tSBNewLogFile,
            this.tSBOpenLog,
            this.tSBOpenLogDir,
            this.toolStripSeparator4,
            this.tSBFindPrevious,
            this.tSBFindNext,
            this.toolStripSeparator5,
            this.tSBScreenShot,
            this.tSBAutoScroll,
            this.tSBTopMost});
            this.ToolStrip.ItemSelectedColor = System.Drawing.Color.Chocolate;
            this.ToolStrip.Location = new System.Drawing.Point(2, 30);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.ToolStrip.ShowItemToolTips = false;
            this.ToolStrip.Size = new System.Drawing.Size(496, 26);
            this.ToolStrip.TabIndex = 77;
            this.ToolStrip.Text = "ToolStrip";
            // 
            // tSBNew
            // 
            this.tSBNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBNew.Image = global::TerminalTool.Properties.Resources.file_add;
            this.tSBNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBNew.Name = "tSBNew";
            this.tSBNew.Size = new System.Drawing.Size(23, 23);
            this.tSBNew.Text = "toolStripButton1";
            this.tSBNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tSBNew.ToolTipText = "new";
            this.tSBNew.Click += new System.EventHandler(this.tSBNew_Click);
            // 
            // tSBConnect
            // 
            this.tSBConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBConnect.Image = global::TerminalTool.Properties.Resources.connection_error;
            this.tSBConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBConnect.Name = "tSBConnect";
            this.tSBConnect.Size = new System.Drawing.Size(23, 23);
            this.tSBConnect.Text = "toolStripButton2";
            this.tSBConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tSBConnect.ToolTipText = "connect";
            this.tSBConnect.Click += new System.EventHandler(this.tSBConnect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // tSBSave
            // 
            this.tSBSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBSave.Image = global::TerminalTool.Properties.Resources.save;
            this.tSBSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBSave.Name = "tSBSave";
            this.tSBSave.Size = new System.Drawing.Size(23, 23);
            this.tSBSave.Text = "toolStripButton3";
            this.tSBSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tSBSave.ToolTipText = "save";
            this.tSBSave.Click += new System.EventHandler(this.tSBSave_Click);
            // 
            // tSBClear
            // 
            this.tSBClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBClear.Image = global::TerminalTool.Properties.Resources.eraser;
            this.tSBClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBClear.Name = "tSBClear";
            this.tSBClear.Size = new System.Drawing.Size(23, 23);
            this.tSBClear.Text = "toolStripButton4";
            this.tSBClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tSBClear.ToolTipText = "clear";
            this.tSBClear.Click += new System.EventHandler(this.tSBClear_Click);
            // 
            // tSBShowLineNum
            // 
            this.tSBShowLineNum.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBShowLineNum.Image = global::TerminalTool.Properties.Resources.list_numbered;
            this.tSBShowLineNum.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBShowLineNum.Name = "tSBShowLineNum";
            this.tSBShowLineNum.Size = new System.Drawing.Size(23, 23);
            this.tSBShowLineNum.Text = "toolStripButton5";
            this.tSBShowLineNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tSBShowLineNum.ToolTipText = "line number";
            this.tSBShowLineNum.Click += new System.EventHandler(this.tSBShowLineNum_Click);
            // 
            // tSBClearTags
            // 
            this.tSBClearTags.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBClearTags.Image = global::TerminalTool.Properties.Resources.tags;
            this.tSBClearTags.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBClearTags.Name = "tSBClearTags";
            this.tSBClearTags.Size = new System.Drawing.Size(23, 23);
            this.tSBClearTags.Text = "toolStripButton6";
            this.tSBClearTags.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tSBClearTags.ToolTipText = "clear tags";
            this.tSBClearTags.Click += new System.EventHandler(this.tSBClearTags_Click);
            // 
            // tSBRecord
            // 
            this.tSBRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBRecord.Image = global::TerminalTool.Properties.Resources.MD_record;
            this.tSBRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBRecord.Name = "tSBRecord";
            this.tSBRecord.Size = new System.Drawing.Size(23, 23);
            this.tSBRecord.Text = "toolStripButton7";
            this.tSBRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tSBRecord.ToolTipText = "record";
            this.tSBRecord.Click += new System.EventHandler(this.tSBRecord_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // tSBNewLogFile
            // 
            this.tSBNewLogFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBNewLogFile.Image = global::TerminalTool.Properties.Resources.file;
            this.tSBNewLogFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBNewLogFile.Name = "tSBNewLogFile";
            this.tSBNewLogFile.Size = new System.Drawing.Size(23, 23);
            this.tSBNewLogFile.Text = "toolStripButton8";
            this.tSBNewLogFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tSBNewLogFile.ToolTipText = "new log";
            this.tSBNewLogFile.Click += new System.EventHandler(this.tSBNewLogFile_Click);
            // 
            // tSBOpenLog
            // 
            this.tSBOpenLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBOpenLog.Image = global::TerminalTool.Properties.Resources.notepad;
            this.tSBOpenLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBOpenLog.Name = "tSBOpenLog";
            this.tSBOpenLog.Size = new System.Drawing.Size(23, 23);
            this.tSBOpenLog.Text = "toolStripButton9";
            this.tSBOpenLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tSBOpenLog.ToolTipText = "open log";
            this.tSBOpenLog.Click += new System.EventHandler(this.tSBOpenLog_Click);
            // 
            // tSBOpenLogDir
            // 
            this.tSBOpenLogDir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBOpenLogDir.Image = global::TerminalTool.Properties.Resources.folder_open;
            this.tSBOpenLogDir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBOpenLogDir.Name = "tSBOpenLogDir";
            this.tSBOpenLogDir.Size = new System.Drawing.Size(23, 23);
            this.tSBOpenLogDir.Text = "toolStripButton10";
            this.tSBOpenLogDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tSBOpenLogDir.ToolTipText = "open log directory";
            this.tSBOpenLogDir.Click += new System.EventHandler(this.tSBOpenLogDir_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // tSBFindPrevious
            // 
            this.tSBFindPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBFindPrevious.Image = global::TerminalTool.Properties.Resources.arrow_2_left;
            this.tSBFindPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBFindPrevious.Name = "tSBFindPrevious";
            this.tSBFindPrevious.Size = new System.Drawing.Size(23, 23);
            this.tSBFindPrevious.Text = "toolStripButton13";
            this.tSBFindPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tSBFindPrevious.ToolTipText = "find previous";
            this.tSBFindPrevious.Click += new System.EventHandler(this.tSBFindPrevious_Click);
            // 
            // tSBFindNext
            // 
            this.tSBFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBFindNext.Image = global::TerminalTool.Properties.Resources.arrow_2_right;
            this.tSBFindNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBFindNext.Name = "tSBFindNext";
            this.tSBFindNext.Size = new System.Drawing.Size(23, 23);
            this.tSBFindNext.Text = "toolStripButton14";
            this.tSBFindNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tSBFindNext.ToolTipText = "find next";
            this.tSBFindNext.Click += new System.EventHandler(this.tSBFindNext_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Margin = new System.Windows.Forms.Padding(0, 1, 0, 2);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
            // 
            // tSBScreenShot
            // 
            this.tSBScreenShot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBScreenShot.Image = global::TerminalTool.Properties.Resources.screenshot;
            this.tSBScreenShot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBScreenShot.Name = "tSBScreenShot";
            this.tSBScreenShot.Size = new System.Drawing.Size(23, 23);
            this.tSBScreenShot.Text = "toolStripButton15";
            this.tSBScreenShot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tSBScreenShot.ToolTipText = "screen shot";
            this.tSBScreenShot.Click += new System.EventHandler(this.tSBScreenShot_Click);
            // 
            // tSBAutoScroll
            // 
            this.tSBAutoScroll.Checked = true;
            this.tSBAutoScroll.CheckOnClick = true;
            this.tSBAutoScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tSBAutoScroll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBAutoScroll.Image = global::TerminalTool.Properties.Resources.map_marker_pin;
            this.tSBAutoScroll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBAutoScroll.Name = "tSBAutoScroll";
            this.tSBAutoScroll.Size = new System.Drawing.Size(23, 23);
            this.tSBAutoScroll.Text = "toolStripButton16";
            this.tSBAutoScroll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tSBAutoScroll.ToolTipText = "auto scroll";
            this.tSBAutoScroll.Click += new System.EventHandler(this.tSBAutoScroll_Click);
            // 
            // tSBTopMost
            // 
            this.tSBTopMost.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tSBTopMost.AutoToolTip = false;
            this.tSBTopMost.CheckOnClick = true;
            this.tSBTopMost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBTopMost.Image = global::TerminalTool.Properties.Resources.pin_16;
            this.tSBTopMost.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBTopMost.Name = "tSBTopMost";
            this.tSBTopMost.Size = new System.Drawing.Size(23, 23);
            this.tSBTopMost.Text = "top most";
            this.tSBTopMost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tSBTopMost.ToolTipText = "top most";
            this.tSBTopMost.Click += new System.EventHandler(this.tSBTopMost_Click);
            // 
            // toolMenu
            // 
            this.toolMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.copyAllToolStripMenuItem});
            this.toolMenu.Name = "toolMenu";
            this.toolMenu.Size = new System.Drawing.Size(125, 70);
            // 
            // copyAllToolStripMenuItem
            // 
            this.copyAllToolStripMenuItem.Name = "copyAllToolStripMenuItem";
            this.copyAllToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.copyAllToolStripMenuItem.Text = "&Copy All";
            this.copyAllToolStripMenuItem.Click += new System.EventHandler(this.copyAllToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.pasteToolStripMenuItem.Text = "&Connect";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackMaxSize = 50;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.btSendMsg);
            this.Controls.Add(this.fctbRcv);
            this.Controls.Add(this.linkZoom);
            this.Controls.Add(this.trackBarZoom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btSendSetting);
            this.Controls.Add(this.tbSend);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelSend);
            this.Controls.Add(this.labelRcv);
            this.Controls.Add(this.labelConnect);
            this.Controls.Add(this.ToolStrip);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2, 30, 2, 8);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.StyleManager = this.StyleMng;
            this.Text = "Terminal";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.cmSys.ResumeLayout(false);
            this.cmSend.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StyleMng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fctbRcv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.toolMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel labelConnect;
        private MetroFramework.Controls.MetroLabel labelRcv;
        private MetroFramework.Controls.MetroLabel labelSend;
        private MetroFramework.Controls.MetroLabel labelTime;
        private MetroFramework.Controls.MetroContextMenu cmSys;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiSystemSetting;
        private System.Windows.Forms.Button btSendSetting;
        private MetroFramework.Controls.MetroTextBox tbSend;
        private FastColoredTextBoxNS.FastColoredTextBox fctbRcv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTrackBar trackBarZoom;
        private MetroFramework.Controls.MetroLink linkZoom;
        private System.IO.Ports.SerialPort serialPort;
        private MetroFramework.Components.MetroToolTip menuToolTip;
        private System.Windows.Forms.Timer LinkTimer;
        private System.Windows.Forms.ToolStripMenuItem tmsiStyleSelect;
        private System.Windows.Forms.ToolStripMenuItem styleDefault;
        private System.Windows.Forms.ToolStripMenuItem styleBlack;
        private System.Windows.Forms.ToolStripMenuItem styleWhite;
        private System.Windows.Forms.ToolStripMenuItem styleSilver;
        private System.Windows.Forms.ToolStripMenuItem styleBlue;
        private System.Windows.Forms.ToolStripMenuItem styleGreen;
        private System.Windows.Forms.ToolStripMenuItem styleLime;
        private System.Windows.Forms.ToolStripMenuItem styleTeal;
        private System.Windows.Forms.ToolStripMenuItem styleOrange;
        private System.Windows.Forms.ToolStripMenuItem styleBrown;
        private System.Windows.Forms.ToolStripMenuItem stylePink;
        private System.Windows.Forms.ToolStripMenuItem styleMagenta;
        private System.Windows.Forms.ToolStripMenuItem stylePurple;
        private System.Windows.Forms.ToolStripMenuItem styleRed;
        private System.Windows.Forms.ToolStripMenuItem styleYellow;
        private MetroFramework.Components.MetroStyleManager StyleMng;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private MetroFramework.Controls.MetroContextMenu cmSend;
        private System.Windows.Forms.ToolStripMenuItem sendTBMSave;
        private System.Windows.Forms.ToolStripMenuItem sendTBMLoop;
        private System.Windows.Forms.ToolStripMenuItem sendTBMSelectScript;
        private System.Windows.Forms.ToolStripMenuItem sendTBMSend;
        private System.Windows.Forms.Timer SendTimer;
        private MetroFramework.Controls.MetroButton btSendMsg;
        private Antiufo.Controls.MetroToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton tSBNew;
        private System.Windows.Forms.ToolStripButton tSBConnect;
        private System.Windows.Forms.ToolStripButton tSBSave;
        private System.Windows.Forms.ToolStripButton tSBClear;
        private System.Windows.Forms.ToolStripButton tSBShowLineNum;
        private System.Windows.Forms.ToolStripButton tSBClearTags;
        private System.Windows.Forms.ToolStripButton tSBRecord;
        private System.Windows.Forms.ToolStripButton tSBNewLogFile;
        private System.Windows.Forms.ToolStripButton tSBOpenLog;
        private System.Windows.Forms.ToolStripButton tSBOpenLogDir;
        private System.Windows.Forms.ToolStripButton tSBFindPrevious;
        private System.Windows.Forms.ToolStripButton tSBFindNext;
        private System.Windows.Forms.ToolStripButton tSBScreenShot;
        private System.Windows.Forms.ToolStripButton tSBAutoScroll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tSBTopMost;
        private MetroFramework.Controls.MetroContextMenu toolMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    }
}

