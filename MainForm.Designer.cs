namespace TerminalTool
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
            this.btAutoScroll = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.btFindNext = new System.Windows.Forms.Button();
            this.btScreenShot = new System.Windows.Forms.Button();
            this.btFindPrevious = new System.Windows.Forms.Button();
            this.btGoForward = new System.Windows.Forms.Button();
            this.btGoBackward = new System.Windows.Forms.Button();
            this.btOpenDir = new System.Windows.Forms.Button();
            this.btOpenLogWithApp = new System.Windows.Forms.Button();
            this.btNewLog = new System.Windows.Forms.Button();
            this.btRecord = new System.Windows.Forms.Button();
            this.btTag = new System.Windows.Forms.Button();
            this.btLine = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btSaveRcv = new System.Windows.Forms.Button();
            this.btOpen = new System.Windows.Forms.Button();
            this.btTopMost = new System.Windows.Forms.Button();
            this.btSendSetting = new System.Windows.Forms.Button();
            this.LinkTimer = new System.Windows.Forms.Timer(this.components);
            this.StyleMng = new MetroFramework.Components.MetroStyleManager(this.components);
            this.panelUpDivide = new MetroFramework.Controls.MetroPanel();
            this.SendTimer = new System.Windows.Forms.Timer(this.components);
            this.btSendMsg = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbSend = new MetroFramework.Controls.MetroTextBox();
            this.fctbRcv = new FastColoredTextBoxNS.FastColoredTextBox();
            this.cmSys.SuspendLayout();
            this.cmSend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StyleMng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fctbRcv)).BeginInit();
            this.SuspendLayout();
            // 
            // labelConnect
            // 
            this.labelConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelConnect.AutoSize = true;
            this.labelConnect.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelConnect.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelConnect.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelConnect.Location = new System.Drawing.Point(5, 384);
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
            this.labelRcv.Location = new System.Drawing.Point(203, 384);
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
            this.labelSend.Location = new System.Drawing.Point(272, 384);
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
            this.labelTime.Location = new System.Drawing.Point(335, 384);
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
            this.panel1.Location = new System.Drawing.Point(413, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 10);
            this.panel1.TabIndex = 50;
            // 
            // trackBarZoom
            // 
            this.trackBarZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarZoom.BackColor = System.Drawing.Color.Transparent;
            this.trackBarZoom.LargeChange = 10;
            this.trackBarZoom.Location = new System.Drawing.Point(427, 385);
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
            this.linkZoom.Location = new System.Drawing.Point(391, 384);
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
            // btAutoScroll
            // 
            this.btAutoScroll.FlatAppearance.BorderSize = 0;
            this.btAutoScroll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btAutoScroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAutoScroll.Font = new System.Drawing.Font("SimSun", 7.5F);
            this.btAutoScroll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btAutoScroll.Image = global::TerminalTool.Properties.Resources.map_marker_pin;
            this.btAutoScroll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btAutoScroll.Location = new System.Drawing.Point(378, 29);
            this.btAutoScroll.Margin = new System.Windows.Forms.Padding(2);
            this.btAutoScroll.Name = "btAutoScroll";
            this.btAutoScroll.Padding = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.btAutoScroll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btAutoScroll.Size = new System.Drawing.Size(21, 21);
            this.btAutoScroll.TabIndex = 76;
            this.btAutoScroll.Tag = "Send";
            this.menuToolTip.SetToolTip(this.btAutoScroll, "Auto Scroll");
            this.btAutoScroll.UseVisualStyleBackColor = true;
            this.btAutoScroll.Click += new System.EventHandler(this.btAutoScroll_Click);
            // 
            // btNew
            // 
            this.btNew.FlatAppearance.BorderSize = 0;
            this.btNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNew.Font = new System.Drawing.Font("SimSun", 7.5F);
            this.btNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btNew.Image = global::TerminalTool.Properties.Resources.file_add;
            this.btNew.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btNew.Location = new System.Drawing.Point(3, 29);
            this.btNew.Margin = new System.Windows.Forms.Padding(2);
            this.btNew.Name = "btNew";
            this.btNew.Padding = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.btNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btNew.Size = new System.Drawing.Size(21, 21);
            this.btNew.TabIndex = 72;
            this.btNew.Tag = "New";
            this.menuToolTip.SetToolTip(this.btNew, "New");
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btFindNext
            // 
            this.btFindNext.FlatAppearance.BorderSize = 0;
            this.btFindNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btFindNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFindNext.Font = new System.Drawing.Font("SimSun", 7.5F);
            this.btFindNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btFindNext.Image = global::TerminalTool.Properties.Resources.arrow_2_right;
            this.btFindNext.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btFindNext.Location = new System.Drawing.Point(328, 29);
            this.btFindNext.Margin = new System.Windows.Forms.Padding(2);
            this.btFindNext.Name = "btFindNext";
            this.btFindNext.Padding = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.btFindNext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btFindNext.Size = new System.Drawing.Size(21, 21);
            this.btFindNext.TabIndex = 67;
            this.btFindNext.Tag = "Send";
            this.menuToolTip.SetToolTip(this.btFindNext, "Find Next");
            this.btFindNext.UseVisualStyleBackColor = true;
            this.btFindNext.Click += new System.EventHandler(this.btFindNext_Click);
            // 
            // btScreenShot
            // 
            this.btScreenShot.FlatAppearance.BorderSize = 0;
            this.btScreenShot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btScreenShot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btScreenShot.Font = new System.Drawing.Font("SimSun", 7.5F);
            this.btScreenShot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btScreenShot.Image = global::TerminalTool.Properties.Resources.screenshot;
            this.btScreenShot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btScreenShot.Location = new System.Drawing.Point(353, 29);
            this.btScreenShot.Margin = new System.Windows.Forms.Padding(2);
            this.btScreenShot.Name = "btScreenShot";
            this.btScreenShot.Padding = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.btScreenShot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btScreenShot.Size = new System.Drawing.Size(21, 21);
            this.btScreenShot.TabIndex = 66;
            this.btScreenShot.Tag = "Send";
            this.menuToolTip.SetToolTip(this.btScreenShot, "ScreenShot");
            this.btScreenShot.UseVisualStyleBackColor = true;
            this.btScreenShot.Click += new System.EventHandler(this.btScreenShot_Click);
            // 
            // btFindPrevious
            // 
            this.btFindPrevious.FlatAppearance.BorderSize = 0;
            this.btFindPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btFindPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFindPrevious.Font = new System.Drawing.Font("SimSun", 7.5F);
            this.btFindPrevious.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btFindPrevious.Image = global::TerminalTool.Properties.Resources.arrow_2_left;
            this.btFindPrevious.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btFindPrevious.Location = new System.Drawing.Point(303, 29);
            this.btFindPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btFindPrevious.Name = "btFindPrevious";
            this.btFindPrevious.Padding = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.btFindPrevious.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btFindPrevious.Size = new System.Drawing.Size(21, 21);
            this.btFindPrevious.TabIndex = 65;
            this.btFindPrevious.Tag = "Send";
            this.menuToolTip.SetToolTip(this.btFindPrevious, "Find Previous");
            this.btFindPrevious.UseVisualStyleBackColor = true;
            this.btFindPrevious.Click += new System.EventHandler(this.btFindPrevious_Click);
            // 
            // btGoForward
            // 
            this.btGoForward.FlatAppearance.BorderSize = 0;
            this.btGoForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btGoForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGoForward.Font = new System.Drawing.Font("SimSun", 7.5F);
            this.btGoForward.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btGoForward.Image = global::TerminalTool.Properties.Resources.arrow_1_forward;
            this.btGoForward.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btGoForward.Location = new System.Drawing.Point(278, 29);
            this.btGoForward.Margin = new System.Windows.Forms.Padding(2);
            this.btGoForward.Name = "btGoForward";
            this.btGoForward.Padding = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.btGoForward.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btGoForward.Size = new System.Drawing.Size(21, 21);
            this.btGoForward.TabIndex = 64;
            this.btGoForward.Tag = "Send";
            this.menuToolTip.SetToolTip(this.btGoForward, "Go Foreward");
            this.btGoForward.UseVisualStyleBackColor = true;
            this.btGoForward.Click += new System.EventHandler(this.btGoForward_Click);
            // 
            // btGoBackward
            // 
            this.btGoBackward.FlatAppearance.BorderSize = 0;
            this.btGoBackward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btGoBackward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGoBackward.Font = new System.Drawing.Font("SimSun", 7.5F);
            this.btGoBackward.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btGoBackward.Image = global::TerminalTool.Properties.Resources.arrow_1_backward;
            this.btGoBackward.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btGoBackward.Location = new System.Drawing.Point(253, 29);
            this.btGoBackward.Margin = new System.Windows.Forms.Padding(2);
            this.btGoBackward.Name = "btGoBackward";
            this.btGoBackward.Padding = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.btGoBackward.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btGoBackward.Size = new System.Drawing.Size(21, 21);
            this.btGoBackward.TabIndex = 63;
            this.btGoBackward.Tag = "Send";
            this.menuToolTip.SetToolTip(this.btGoBackward, "Go Backward");
            this.btGoBackward.UseVisualStyleBackColor = true;
            this.btGoBackward.Click += new System.EventHandler(this.btGoBackward_Click);
            // 
            // btOpenDir
            // 
            this.btOpenDir.FlatAppearance.BorderSize = 0;
            this.btOpenDir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btOpenDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpenDir.Font = new System.Drawing.Font("SimSun", 7.5F);
            this.btOpenDir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btOpenDir.Image = global::TerminalTool.Properties.Resources.folder_open;
            this.btOpenDir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btOpenDir.Location = new System.Drawing.Point(228, 29);
            this.btOpenDir.Margin = new System.Windows.Forms.Padding(2);
            this.btOpenDir.Name = "btOpenDir";
            this.btOpenDir.Padding = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.btOpenDir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btOpenDir.Size = new System.Drawing.Size(21, 21);
            this.btOpenDir.TabIndex = 62;
            this.btOpenDir.Tag = "Send";
            this.menuToolTip.SetToolTip(this.btOpenDir, "Open Directory");
            this.btOpenDir.UseVisualStyleBackColor = true;
            this.btOpenDir.Click += new System.EventHandler(this.btOpenDir_Click);
            // 
            // btOpenLogWithApp
            // 
            this.btOpenLogWithApp.FlatAppearance.BorderSize = 0;
            this.btOpenLogWithApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btOpenLogWithApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpenLogWithApp.Font = new System.Drawing.Font("SimSun", 7.5F);
            this.btOpenLogWithApp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btOpenLogWithApp.Image = global::TerminalTool.Properties.Resources.notepad;
            this.btOpenLogWithApp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btOpenLogWithApp.Location = new System.Drawing.Point(203, 29);
            this.btOpenLogWithApp.Margin = new System.Windows.Forms.Padding(2);
            this.btOpenLogWithApp.Name = "btOpenLogWithApp";
            this.btOpenLogWithApp.Padding = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.btOpenLogWithApp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btOpenLogWithApp.Size = new System.Drawing.Size(21, 21);
            this.btOpenLogWithApp.TabIndex = 61;
            this.btOpenLogWithApp.Tag = "Send";
            this.menuToolTip.SetToolTip(this.btOpenLogWithApp, "Open Log");
            this.btOpenLogWithApp.UseVisualStyleBackColor = true;
            this.btOpenLogWithApp.Click += new System.EventHandler(this.btOpenLogWithApp_Click);
            // 
            // btNewLog
            // 
            this.btNewLog.FlatAppearance.BorderSize = 0;
            this.btNewLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btNewLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNewLog.Font = new System.Drawing.Font("SimSun", 7.5F);
            this.btNewLog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btNewLog.Image = global::TerminalTool.Properties.Resources.file;
            this.btNewLog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btNewLog.Location = new System.Drawing.Point(178, 29);
            this.btNewLog.Margin = new System.Windows.Forms.Padding(2);
            this.btNewLog.Name = "btNewLog";
            this.btNewLog.Padding = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.btNewLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btNewLog.Size = new System.Drawing.Size(21, 21);
            this.btNewLog.TabIndex = 60;
            this.btNewLog.Tag = "Send";
            this.menuToolTip.SetToolTip(this.btNewLog, "New Log File");
            this.btNewLog.UseVisualStyleBackColor = true;
            this.btNewLog.Click += new System.EventHandler(this.btNewLog_Click);
            // 
            // btRecord
            // 
            this.btRecord.FlatAppearance.BorderSize = 0;
            this.btRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRecord.Font = new System.Drawing.Font("SimSun", 7.5F);
            this.btRecord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btRecord.Image = global::TerminalTool.Properties.Resources.MD_record;
            this.btRecord.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btRecord.Location = new System.Drawing.Point(153, 29);
            this.btRecord.Margin = new System.Windows.Forms.Padding(2);
            this.btRecord.Name = "btRecord";
            this.btRecord.Padding = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.btRecord.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btRecord.Size = new System.Drawing.Size(21, 21);
            this.btRecord.TabIndex = 59;
            this.btRecord.Tag = "true";
            this.menuToolTip.SetToolTip(this.btRecord, "Record");
            this.btRecord.UseVisualStyleBackColor = true;
            this.btRecord.Click += new System.EventHandler(this.btRecord_Click);
            // 
            // btTag
            // 
            this.btTag.FlatAppearance.BorderSize = 0;
            this.btTag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTag.Font = new System.Drawing.Font("SimSun", 7.5F);
            this.btTag.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btTag.Image = global::TerminalTool.Properties.Resources.tags;
            this.btTag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btTag.Location = new System.Drawing.Point(128, 29);
            this.btTag.Margin = new System.Windows.Forms.Padding(2);
            this.btTag.Name = "btTag";
            this.btTag.Padding = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.btTag.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btTag.Size = new System.Drawing.Size(21, 21);
            this.btTag.TabIndex = 58;
            this.btTag.Tag = "Send";
            this.menuToolTip.SetToolTip(this.btTag, "Clear Tags");
            this.btTag.UseVisualStyleBackColor = true;
            this.btTag.Click += new System.EventHandler(this.btTag_Click);
            // 
            // btLine
            // 
            this.btLine.FlatAppearance.BorderSize = 0;
            this.btLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLine.Font = new System.Drawing.Font("SimSun", 7.5F);
            this.btLine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btLine.Image = global::TerminalTool.Properties.Resources.list_numbered;
            this.btLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btLine.Location = new System.Drawing.Point(103, 29);
            this.btLine.Margin = new System.Windows.Forms.Padding(2);
            this.btLine.Name = "btLine";
            this.btLine.Padding = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.btLine.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btLine.Size = new System.Drawing.Size(21, 21);
            this.btLine.TabIndex = 57;
            this.btLine.Tag = "Send";
            this.menuToolTip.SetToolTip(this.btLine, "Show Line Number");
            this.btLine.UseVisualStyleBackColor = true;
            this.btLine.Click += new System.EventHandler(this.btLine_Click);
            // 
            // btClear
            // 
            this.btClear.FlatAppearance.BorderSize = 0;
            this.btClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClear.Font = new System.Drawing.Font("SimSun", 7.5F);
            this.btClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btClear.Image = global::TerminalTool.Properties.Resources.eraser;
            this.btClear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btClear.Location = new System.Drawing.Point(78, 29);
            this.btClear.Margin = new System.Windows.Forms.Padding(2);
            this.btClear.Name = "btClear";
            this.btClear.Padding = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.btClear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btClear.Size = new System.Drawing.Size(21, 21);
            this.btClear.TabIndex = 56;
            this.btClear.Tag = "Send";
            this.menuToolTip.SetToolTip(this.btClear, "Clear");
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btSaveRcv
            // 
            this.btSaveRcv.FlatAppearance.BorderSize = 0;
            this.btSaveRcv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btSaveRcv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSaveRcv.Font = new System.Drawing.Font("SimSun", 7.5F);
            this.btSaveRcv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSaveRcv.Image = global::TerminalTool.Properties.Resources.save;
            this.btSaveRcv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSaveRcv.Location = new System.Drawing.Point(53, 29);
            this.btSaveRcv.Margin = new System.Windows.Forms.Padding(2);
            this.btSaveRcv.Name = "btSaveRcv";
            this.btSaveRcv.Padding = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.btSaveRcv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btSaveRcv.Size = new System.Drawing.Size(21, 21);
            this.btSaveRcv.TabIndex = 55;
            this.btSaveRcv.Tag = "Send";
            this.menuToolTip.SetToolTip(this.btSaveRcv, "Save");
            this.btSaveRcv.UseVisualStyleBackColor = true;
            this.btSaveRcv.Click += new System.EventHandler(this.btSaveRcv_Click);
            // 
            // btOpen
            // 
            this.btOpen.FlatAppearance.BorderSize = 0;
            this.btOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpen.Font = new System.Drawing.Font("SimSun", 7.5F);
            this.btOpen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btOpen.Image = global::TerminalTool.Properties.Resources.connection_error;
            this.btOpen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btOpen.Location = new System.Drawing.Point(28, 29);
            this.btOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btOpen.Name = "btOpen";
            this.btOpen.Padding = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.btOpen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btOpen.Size = new System.Drawing.Size(21, 21);
            this.btOpen.TabIndex = 54;
            this.btOpen.Tag = "Open/Close";
            this.menuToolTip.SetToolTip(this.btOpen, "Open/Close");
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btTopMost
            // 
            this.btTopMost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTopMost.FlatAppearance.BorderSize = 0;
            this.btTopMost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btTopMost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTopMost.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btTopMost.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btTopMost.Image = global::TerminalTool.Properties.Resources.pin_24px_1116541_easyicon_net;
            this.btTopMost.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btTopMost.Location = new System.Drawing.Point(390, 5);
            this.btTopMost.Margin = new System.Windows.Forms.Padding(2);
            this.btTopMost.Name = "btTopMost";
            this.btTopMost.Padding = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.btTopMost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btTopMost.Size = new System.Drawing.Size(20, 20);
            this.btTopMost.TabIndex = 53;
            this.btTopMost.Tag = "Send";
            this.menuToolTip.SetToolTip(this.btTopMost, "Top Most");
            this.btTopMost.UseVisualStyleBackColor = true;
            this.btTopMost.Click += new System.EventHandler(this.btTopMost_Click);
            // 
            // btSendSetting
            // 
            this.btSendSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSendSetting.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btSendSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btSendSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSendSetting.Image = global::TerminalTool.Properties.Resources.ftp;
            this.btSendSetting.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSendSetting.Location = new System.Drawing.Point(475, 359);
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
            // panelUpDivide
            // 
            this.panelUpDivide.BackColor = System.Drawing.Color.Gainsboro;
            this.panelUpDivide.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpDivide.HorizontalScrollbarBarColor = true;
            this.panelUpDivide.HorizontalScrollbarHighlightOnWheel = false;
            this.panelUpDivide.HorizontalScrollbarSize = 10;
            this.panelUpDivide.Location = new System.Drawing.Point(1, 52);
            this.panelUpDivide.Name = "panelUpDivide";
            this.panelUpDivide.Size = new System.Drawing.Size(498, 1);
            this.panelUpDivide.TabIndex = 74;
            this.panelUpDivide.UseCustomBackColor = true;
            this.panelUpDivide.VerticalScrollbarBarColor = true;
            this.panelUpDivide.VerticalScrollbarHighlightOnWheel = false;
            this.panelUpDivide.VerticalScrollbarSize = 10;
            // 
            // SendTimer
            // 
            this.SendTimer.Interval = 1000;
            this.SendTimer.Tick += new System.EventHandler(this.SendTimer_Tick);
            // 
            // btSendMsg
            // 
            this.btSendMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSendMsg.Location = new System.Drawing.Point(437, 359);
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
            this.tbSend.CustomButton.Location = new System.Drawing.Point(417, 2);
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
            this.tbSend.Location = new System.Drawing.Point(1, 359);
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
            this.tbSend.Size = new System.Drawing.Size(437, 22);
            this.tbSend.TabIndex = 48;
            this.tbSend.UseSelectable = true;
            this.tbSend.UseStyleColors = true;
            this.tbSend.WaterMark = "send...";
            this.tbSend.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSend.WaterMarkFont = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSend.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.tbSend_ButtonClick);
            this.tbSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSend_KeyDown);
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
            this.fctbRcv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbRcv.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbRcv.IndentBackColor = System.Drawing.Color.White;
            this.fctbRcv.IsReplaceMode = false;
            this.fctbRcv.Location = new System.Drawing.Point(1, 52);
            this.fctbRcv.Margin = new System.Windows.Forms.Padding(0);
            this.fctbRcv.Name = "fctbRcv";
            this.fctbRcv.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbRcv.ReadOnly = true;
            this.fctbRcv.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbRcv.ServiceColors = null;
            this.fctbRcv.ServiceLinesColor = System.Drawing.Color.DeepSkyBlue;
            this.fctbRcv.Size = new System.Drawing.Size(498, 305);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackMaxSize = 50;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.btAutoScroll);
            this.Controls.Add(this.btSendMsg);
            this.Controls.Add(this.panelUpDivide);
            this.Controls.Add(this.fctbRcv);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.linkZoom);
            this.Controls.Add(this.trackBarZoom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btFindNext);
            this.Controls.Add(this.btScreenShot);
            this.Controls.Add(this.btFindPrevious);
            this.Controls.Add(this.btGoForward);
            this.Controls.Add(this.btGoBackward);
            this.Controls.Add(this.btOpenDir);
            this.Controls.Add(this.btOpenLogWithApp);
            this.Controls.Add(this.btNewLog);
            this.Controls.Add(this.btRecord);
            this.Controls.Add(this.btTag);
            this.Controls.Add(this.btLine);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btSaveRcv);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.btTopMost);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btSendSetting);
            this.Controls.Add(this.tbSend);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelSend);
            this.Controls.Add(this.labelRcv);
            this.Controls.Add(this.labelConnect);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(1, 52, 1, 8);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.StyleManager = this.StyleMng;
            this.Text = "Terminal";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.cmSys.ResumeLayout(false);
            this.cmSend.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StyleMng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fctbRcv)).EndInit();
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
        private System.Windows.Forms.Button btTopMost;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btSaveRcv;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btLine;
        private System.Windows.Forms.Button btTag;
        private System.Windows.Forms.Button btRecord;
        private System.Windows.Forms.Button btFindPrevious;
        private System.Windows.Forms.Button btGoForward;
        private System.Windows.Forms.Button btGoBackward;
        private System.Windows.Forms.Button btOpenDir;
        private System.Windows.Forms.Button btOpenLogWithApp;
        private System.Windows.Forms.Button btNewLog;
        private System.Windows.Forms.Button btScreenShot;
        private System.Windows.Forms.Button btFindNext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTrackBar trackBarZoom;
        private MetroFramework.Controls.MetroLink linkZoom;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button btNew;
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
        private MetroFramework.Controls.MetroPanel panelUpDivide;
        private System.Windows.Forms.Timer SendTimer;
        private MetroFramework.Controls.MetroButton btSendMsg;
        private System.Windows.Forms.Button btAutoScroll;
    }
}

