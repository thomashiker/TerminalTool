namespace TerminalTool
{
    partial class SendToolForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridCmdList = new MetroFramework.Controls.MetroGrid();
            this.ColumnCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnCmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmSendTool = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StyleMng = new MetroFramework.Components.MetroStyleManager(this.components);
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new MetroFramework.Components.MetroToolTip();
            this.labelInfo = new MetroFramework.Controls.MetroLabel();
            this.dividePanel = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridCmdList)).BeginInit();
            this.cmSendTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StyleMng)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCmdList
            // 
            this.gridCmdList.AllowUserToOrderColumns = true;
            this.gridCmdList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.gridCmdList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCmdList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCmdList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCmdList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridCmdList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCmdList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridCmdList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gridCmdList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridCmdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCmdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCheck,
            this.ColumnCmd,
            this.ColumnEdit});
            this.gridCmdList.ContextMenuStrip = this.cmSendTool;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCmdList.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridCmdList.EnableHeadersVisualStyles = false;
            this.gridCmdList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridCmdList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridCmdList.Location = new System.Drawing.Point(2, 6);
            this.gridCmdList.Margin = new System.Windows.Forms.Padding(0);
            this.gridCmdList.MultiSelect = false;
            this.gridCmdList.Name = "gridCmdList";
            this.gridCmdList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gridCmdList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridCmdList.RowHeadersVisible = false;
            this.gridCmdList.RowHeadersWidth = 25;
            this.gridCmdList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridCmdList.RowTemplate.Height = 23;
            this.gridCmdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCmdList.Size = new System.Drawing.Size(396, 134);
            this.gridCmdList.TabIndex = 51;
            this.gridCmdList.UseStyleColors = true;
            this.gridCmdList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCmdList_CellDoubleClick);
            this.gridCmdList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCmdList_CellValueChanged);
            this.gridCmdList.SelectionChanged += new System.EventHandler(this.gridCmdList_SelectionChanged);
            // 
            // ColumnCheck
            // 
            this.ColumnCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.NullValue = false;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.ColumnCheck.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnCheck.DividerWidth = 1;
            this.ColumnCheck.FillWeight = 50F;
            this.ColumnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnCheck.HeaderText = "";
            this.ColumnCheck.MinimumWidth = 21;
            this.ColumnCheck.Name = "ColumnCheck";
            this.ColumnCheck.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnCheck.Width = 21;
            // 
            // ColumnCmd
            // 
            this.ColumnCmd.DividerWidth = 1;
            this.ColumnCmd.FillWeight = 265.6086F;
            this.ColumnCmd.HeaderText = "Cmd";
            this.ColumnCmd.Name = "ColumnCmd";
            this.ColumnCmd.ReadOnly = true;
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.NullValue = false;
            this.ColumnEdit.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnEdit.FillWeight = 50F;
            this.ColumnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnEdit.HeaderText = "Edit";
            this.ColumnEdit.MinimumWidth = 32;
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnEdit.ToolTipText = "Click To Edit";
            this.ColumnEdit.Width = 32;
            // 
            // cmSendTool
            // 
            this.cmSendTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmSendTool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmSendTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.addToolStripMenuItem,
            this.toolStripSeparator4,
            this.copyToolStripMenuItem,
            this.copyAllToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.toolStripSeparator2,
            this.sendToolStripMenuItem,
            this.loopToolStripMenuItem});
            this.cmSendTool.Name = "cmSendTool";
            this.cmSendTool.Size = new System.Drawing.Size(125, 214);
            this.cmSendTool.UseStyleColors = true;
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.addToolStripMenuItem.Text = "&Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(121, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // copyAllToolStripMenuItem
            // 
            this.copyAllToolStripMenuItem.Name = "copyAllToolStripMenuItem";
            this.copyAllToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.copyAllToolStripMenuItem.Text = "Copy &All";
            this.copyAllToolStripMenuItem.Click += new System.EventHandler(this.copyAllToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadFileToolStripMenuItem,
            this.saveToFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // uploadFileToolStripMenuItem
            // 
            this.uploadFileToolStripMenuItem.Name = "uploadFileToolStripMenuItem";
            this.uploadFileToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.uploadFileToolStripMenuItem.Text = "&Upload File";
            this.uploadFileToolStripMenuItem.Click += new System.EventHandler(this.uploadFileToolStripMenuItem_Click_1);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.saveToFileToolStripMenuItem.Text = "&Save To File";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.saveToFileToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(121, 6);
            // 
            // sendToolStripMenuItem
            // 
            this.sendToolStripMenuItem.Name = "sendToolStripMenuItem";
            this.sendToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.sendToolStripMenuItem.Text = "&Send";
            this.sendToolStripMenuItem.Click += new System.EventHandler(this.sendToolStripMenuItem_Click);
            // 
            // loopToolStripMenuItem
            // 
            this.loopToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.loopToolStripMenuItem.Image = global::TerminalTool.Properties.Resources.arrow_3_down_right;
            this.loopToolStripMenuItem.Name = "loopToolStripMenuItem";
            this.loopToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.loopToolStripMenuItem.Text = "&Loop";
            this.loopToolStripMenuItem.Click += new System.EventHandler(this.loopToolStripMenuItem_Click);
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
            // labelInfo
            // 
            this.labelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelInfo.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelInfo.Location = new System.Drawing.Point(0, 144);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(400, 16);
            this.labelInfo.TabIndex = 52;
            this.labelInfo.UseStyleColors = true;
            // 
            // dividePanel
            // 
            this.dividePanel.BackColor = System.Drawing.Color.Lime;
            this.dividePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dividePanel.HorizontalScrollbarBarColor = true;
            this.dividePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.dividePanel.HorizontalScrollbarSize = 10;
            this.dividePanel.Location = new System.Drawing.Point(0, 143);
            this.dividePanel.Name = "dividePanel";
            this.dividePanel.Size = new System.Drawing.Size(400, 1);
            this.dividePanel.TabIndex = 53;
            this.dividePanel.UseCustomBackColor = true;
            this.dividePanel.UseStyleColors = true;
            this.dividePanel.VerticalScrollbarBarColor = true;
            this.dividePanel.VerticalScrollbarHighlightOnWheel = false;
            this.dividePanel.VerticalScrollbarSize = 10;
            // 
            // SendToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 160);
            this.ControlBox = false;
            this.Controls.Add(this.dividePanel);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.gridCmdList);
            this.DisplayHeader = false;
            this.Name = "SendToolForm";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SendToolForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridCmdList)).EndInit();
            this.cmSendTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StyleMng)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroContextMenu cmSendTool;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToolStripMenuItem;
        private MetroFramework.Components.MetroStyleManager StyleMng;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private MetroFramework.Controls.MetroGrid gridCmdList;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private MetroFramework.Components.MetroToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loopToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCmd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnEdit;
        private MetroFramework.Controls.MetroLabel labelInfo;
        private MetroFramework.Controls.MetroPanel dividePanel;
    }
}