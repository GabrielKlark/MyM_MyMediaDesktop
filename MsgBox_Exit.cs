using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernUI
{
    public partial class MsgBox_Exit : Form
    {
        public MsgBox_Exit()
        {
            InitializeComponent();
        }

        DialogResult Answer = DialogResult.Cancel;

        private void btnYes_Click(object sender, EventArgs e)
        {
            Answer = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Answer = DialogResult.No;
            this.Close();
        }
    }
}
