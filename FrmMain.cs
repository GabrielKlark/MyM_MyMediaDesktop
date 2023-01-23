using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ModernUI
{
    public partial class FrmMain : Form
    {
        cl_ControlMedia control = new cl_ControlMedia();

        public FrmMain()
        {
            InitializeComponent();
            OpenFormSon(new FrmHome());
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //FrmLogin frmLogin = new FrmLogin();
            //frmLogin.ShowDialog();
            
            //cl_ConnectionMySQL c = new cl_ConnectionMySQL();
            //MessageBox.Show(c.connect());
        }

        //Exit Function
        private void Exit()
        {
            DialogResult Exit = MessageBox.Show("Are you sure you want to leave?","Leaving",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            switch (Exit)
            {
                case DialogResult.Yes:
                {
                        Application.Exit();
                        break;
                }
                case DialogResult.No:
                    {
                        break;
                    }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnReset.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnReset.Visible = false;
            btnMax.Visible = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSMRExpen_Click(object sender, EventArgs e)
        {
            panelSubMenuBackups.Visible = false;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void OpenFormSon(object formSon)
        {
            if (this.panelContent.Controls.Count > 0)
                this.panelContent.Controls.RemoveAt(0);

            Form fS = formSon as Form;

            fS.TopLevel = false;
            fS.Dock = DockStyle.Fill;

            this.panelContent.Controls.Add(fS);
            this.panelContent.Tag = fS;
            fS.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenFormSon(new FrmHome());
        }

        private void btnMyWatchlist_Click(object sender, EventArgs e)
        {
            OpenFormSon(new Frm1_Watchlist());

            if (panelSubMenuBackups.Visible == true)
            {
                panelSubMenuBackups.Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFormSon(new Frm2_Add());

            if (panelSubMenuBackups.Visible == true)
            {
                panelSubMenuBackups.Visible = false;
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            OpenFormSon(new Frm3_Report());

            if (panelSubMenuBackups.Visible == true)
            {
                panelSubMenuBackups.Visible = false;
            }
        }

        private void btnBackupOptions_Click(object sender, EventArgs e)
        {
            OpenFormSon(new FrmHome());

            if (panelSubMenuBackups.Visible == false)
            {
                panelSubMenuBackups.Visible = true;
            }
            else
            {
                panelSubMenuBackups.Visible = false;
            }
        }

        private void btnDoBackup_Click(object sender, EventArgs e)
        {
            panelSubMenuBackups.Visible = false;
            MessageBox.Show(control.dbBackup("C:\\DS_Backups"), "Backup Sucessfully Located!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            panelSubMenuBackups.Visible = false;

            OpenFileDialog ofdRestore = new OpenFileDialog();
            ofdRestore.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*";

            if (ofdRestore.ShowDialog() == DialogResult.OK)
            {
                string pathBackup = ofdRestore.FileName;
                MessageBox.Show(control.dbRestore(pathBackup), "Database Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormSon(new FrmAbout());
        }
    }
}
