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

namespace TerminalTool
{
    public partial class HelpForm : MetroForm
    {
        public HelpForm()
        {
            InitializeComponent();
            StyleManager = metroStyleMng;
        }

        public MetroColorStyle MetroStyle
        {
            get { return metroStyleMng.Style; }
            set
            {
                metroStyleMng.Style = value;
                dividePanel.BackColor = MetroPaint.GetStyleColor(metroStyleMng.Style);
            }
        }

        private void internetLink_Click(object sender, EventArgs e)
        {
            if (null != internetLink.Text)
            {
                System.Diagnostics.Process.Start(internetLink.Text);
                //System.Diagnostics.Process.Start("explorer.exe", internetLink.Text);
            }
        }
    }
}
