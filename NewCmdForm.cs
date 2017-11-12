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
using MetroFramework.Controls;

namespace TerminalTool
{
    public partial class NewCmdForm : MetroForm
    {
        public NewCmdForm()
        {
            InitializeComponent();
        }

        public string GetNewCmd()
        {
            return tbCmd.Text;
        }
        public void SetNewCmd(string cmd)
        {
            tbCmd.Text = cmd;
        }

        public string GetNewCmdName()
        {
            return tbCmdName.Text;
        }
        public void SetNewCmdName(string name)
        {
            tbCmdName.Text = name;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
