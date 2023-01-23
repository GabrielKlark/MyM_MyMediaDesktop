using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace ModernUI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            // Create theme manager
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Set form components color;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red700, Primary.Red900,
                Primary.Red400, Accent.Red700,
                TextShade.BLACK
            );
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            FrmSignup Signup = new FrmSignup();
            Signup.ShowDialog();

            // Create theme manager
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Set form components color;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue700, Primary.Blue700,
                Primary.Blue400, Accent.Blue700,
                TextShade.BLACK
            );
        }

        cl_Login lgn = new cl_Login();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Login and password can't be blank!", "Info Missing!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    bool login = lgn.LogIn(txtLogin.Text, txtPass.Text);

                    if (login == true)
                    {
                        this.Hide();
                        FrmMain Main = new FrmMain();
                        Main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login and/or password wrong!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLogin.Clear();
                        txtPass.Clear();
                        txtLogin.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            DialogResult Exit = MessageBox.Show("Are you sure you want to leave?", "Leaving", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
    }
}
