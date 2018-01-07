namespace TerminalTool
{
    partial class HelpForm
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
            this.internetLink = new MetroFramework.Controls.MetroLink();
            this.dividePanel = new MetroFramework.Controls.MetroPanel();
            this.metroStyleMng = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleMng)).BeginInit();
            this.SuspendLayout();
            // 
            // internetLink
            // 
            this.internetLink.Location = new System.Drawing.Point(22, 80);
            this.internetLink.Name = "internetLink";
            this.internetLink.Size = new System.Drawing.Size(306, 23);
            this.internetLink.TabIndex = 0;
            this.internetLink.Text = "https://github.com/thomashiker/TerminalTool";
            this.internetLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.internetLink.UseSelectable = true;
            this.internetLink.UseStyleColors = true;
            this.internetLink.Click += new System.EventHandler(this.internetLink_Click);
            // 
            // dividePanel
            // 
            this.dividePanel.BackColor = System.Drawing.Color.Black;
            this.dividePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dividePanel.HorizontalScrollbarBarColor = true;
            this.dividePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.dividePanel.HorizontalScrollbarSize = 10;
            this.dividePanel.Location = new System.Drawing.Point(20, 60);
            this.dividePanel.Name = "dividePanel";
            this.dividePanel.Size = new System.Drawing.Size(319, 2);
            this.dividePanel.TabIndex = 1;
            this.dividePanel.UseCustomBackColor = true;
            this.dividePanel.UseStyleColors = true;
            this.dividePanel.VerticalScrollbarBarColor = true;
            this.dividePanel.VerticalScrollbarHighlightOnWheel = false;
            this.dividePanel.VerticalScrollbarSize = 10;
            // 
            // metroStyleMng
            // 
            this.metroStyleMng.Owner = this;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 129);
            this.Controls.Add(this.dividePanel);
            this.Controls.Add(this.internetLink);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 180);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 120);
            this.Name = "HelpForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleMng)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink internetLink;
        private MetroFramework.Controls.MetroPanel dividePanel;
        private MetroFramework.Components.MetroStyleManager metroStyleMng;
    }
}