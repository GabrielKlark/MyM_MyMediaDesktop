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
    public partial class FrmSignup : Form
    {
        public FrmSignup()
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

        private void clear()
        {
            txtNick.Clear();
            txtEmail.Clear();
            txtPass.Clear();
            txtCoPass.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == txtCoPass.Text)
            {
                cl_User user = new cl_User();
                cl_Login login = new cl_Login();

                user.Login = txtNick.Text;
                user.Pass = txtPass.Text.ToLower();
                user.Email = txtEmail.Text.ToLower();

                MessageBox.Show(login.registeringLogin(user),"Sing Up",MessageBoxButtons.OK,MessageBoxIcon.Information);

                clear();
            }
            else
            {
                MessageBox.Show("Both password fields must be with the same information.","Passwords don't match!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void activeBtnReg()
        {
            if(
                txtNick.TextLength >= 8 &&
                txtEmail.TextLength >= 8 &&
                txtPass.TextLength >= 8 &&
                txtCoPass.TextLength >= 8
               )
            {
                btnRegister.Enabled = true;
            }
            else
            {
                btnRegister.Enabled = false;
            }
        }

        private void txtNick_TextChanged(object sender, EventArgs e)
        {
            activeBtnReg();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            activeBtnReg();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            activeBtnReg();
        }

        private void txtCoPass_TextChanged(object sender, EventArgs e)
        {
            activeBtnReg();
        }

        private void txtNick_KeyPress(object sender, KeyPressEventArgs e)
        {
            //If type isn't a number, bars either backspace
            if (e.KeyChar == 32)
            {
                //Canceling the event
                e.Handled = true;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //If type isn't a number, bars either backspace
            if (e.KeyChar == 32)
            {
                //Canceling the event
                e.Handled = true;
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            //If type isn't a number, bars either backspace
            if (e.KeyChar == 32)
            {
                //Canceling the event
                e.Handled = true;
            }
        }

        private void txtCoPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            //If type isn't a number, bars either backspace
            if (e.KeyChar == 32)
            {
                //Canceling the event
                e.Handled = true;
            }
        }
    }
}
