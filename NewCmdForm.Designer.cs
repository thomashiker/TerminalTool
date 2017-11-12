namespace TerminalTool
{
    partial class NewCmdForm
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
            this.tbCmd = new MetroFramework.Controls.MetroTextBox();
            this.tbCmdName = new MetroFramework.Controls.MetroTextBox();
            this.btOk = new MetroFramework.Controls.MetroButton();
            this.btCancel = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // tbCmd
            // 
            // 
            // 
            // 
            this.tbCmd.CustomButton.Image = null;
            this.tbCmd.CustomButton.Location = new System.Drawing.Point(267, 1);
            this.tbCmd.CustomButton.Name = "";
            this.tbCmd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbCmd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCmd.CustomButton.TabIndex = 1;
            this.tbCmd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCmd.CustomButton.UseSelectable = true;
            this.tbCmd.CustomButton.Visible = false;
            this.tbCmd.Lines = new string[0];
            this.tbCmd.Location = new System.Drawing.Point(67, 22);
            this.tbCmd.MaxLength = 32767;
            this.tbCmd.Name = "tbCmd";
            this.tbCmd.PasswordChar = '\0';
            this.tbCmd.PromptText = "input cmd...";
            this.tbCmd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCmd.SelectedText = "";
            this.tbCmd.SelectionLength = 0;
            this.tbCmd.SelectionStart = 0;
            this.tbCmd.ShortcutsEnabled = true;
            this.tbCmd.ShowClearButton = true;
            this.tbCmd.Size = new System.Drawing.Size(289, 23);
            this.tbCmd.TabIndex = 0;
            this.tbCmd.UseSelectable = true;
            this.tbCmd.UseStyleColors = true;
            this.tbCmd.WaterMark = "input cmd...";
            this.tbCmd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCmd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbCmdName
            // 
            // 
            // 
            // 
            this.tbCmdName.CustomButton.Image = null;
            this.tbCmdName.CustomButton.Location = new System.Drawing.Point(267, 1);
            this.tbCmdName.CustomButton.Name = "";
            this.tbCmdName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbCmdName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCmdName.CustomButton.TabIndex = 1;
            this.tbCmdName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCmdName.CustomButton.UseSelectable = true;
            this.tbCmdName.CustomButton.Visible = false;
            this.tbCmdName.Lines = new string[0];
            this.tbCmdName.Location = new System.Drawing.Point(67, 52);
            this.tbCmdName.MaxLength = 32767;
            this.tbCmdName.Name = "tbCmdName";
            this.tbCmdName.PasswordChar = '\0';
            this.tbCmdName.PromptText = "input cmd name...";
            this.tbCmdName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCmdName.SelectedText = "";
            this.tbCmdName.SelectionLength = 0;
            this.tbCmdName.SelectionStart = 0;
            this.tbCmdName.ShortcutsEnabled = true;
            this.tbCmdName.ShowClearButton = true;
            this.tbCmdName.Size = new System.Drawing.Size(289, 23);
            this.tbCmdName.TabIndex = 1;
            this.tbCmdName.UseSelectable = true;
            this.tbCmdName.UseStyleColors = true;
            this.tbCmdName.WaterMark = "input cmd name...";
            this.tbCmdName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCmdName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btOk
            // 
            this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOk.Location = new System.Drawing.Point(228, 96);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(60, 23);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "&Ok";
            this.btOk.UseCustomBackColor = true;
            this.btOk.UseSelectable = true;
            this.btOk.UseStyleColors = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.Location = new System.Drawing.Point(292, 96);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(60, 23);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "&Cancel";
            this.btCancel.UseCustomBackColor = true;
            this.btCancel.UseSelectable = true;
            this.btCancel.UseStyleColors = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(8, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Cmd";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(8, 54);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Name";
            this.metroLabel2.UseStyleColors = true;
            // 
            // AddNewCmdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 128);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.tbCmdName);
            this.Controls.Add(this.tbCmd);
            this.DisplayHeader = false;
            this.Name = "AddNewCmdForm";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddNewCmdForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tbCmd;
        private MetroFramework.Controls.MetroTextBox tbCmdName;
        private MetroFramework.Controls.MetroButton btOk;
        private MetroFramework.Controls.MetroButton btCancel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}