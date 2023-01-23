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
using MySql.Data.MySqlClient;

namespace ModernUI
{
    public partial class Frm2_Add : Form
    {
        cl_Media Media = new cl_Media();
        cl_ControlMedia Control = new cl_ControlMedia();

        public Frm2_Add()
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
            txtCod.Clear();
            txtTitle.Clear();
            txtDate.Clear();
            txtSeason.Clear();
            txtSynopsis.Clear();

            txtCod.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || txtTitle.Text == " ")
            {
                MessageBox.Show("You must fill the title to register anything!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Title
                Media.Title_M = txtTitle.Text;
                
                //Date
                if (txtDate.Text == "")
                {
                    //Set Null if txt is empty
                    Media.Date_M = "null";
                }
                else
                {
                    Media.Date_M = ($"'{txtDate.Text}'");
                }

                //Season
                if (txtSeason.Text == "")
                {
                    //Set Null if txt is empty
                    Media.Season_M = 0;
                }
                else
                {
                    Media.Season_M = Convert.ToInt32(txtSeason.Text);
                }

                //Season
                if (txtSynopsis.Text == "" || txtSynopsis.Text == " ")
                {
                    //Set Null if txt is empty
                    Media.Synopsis_M = "'...'";
                }
                else
                {
                    Media.Synopsis_M = ($"'{txtSynopsis.Text}'");
                } 

                MessageBox.Show(Control.registering(Media));

                clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCod.Text == "" || txtCod.Text == " ") 
            {
                MessageBox.Show("You must fill the code to delete anything!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Media.Cod_M = Convert.ToInt32(txtCod.Text);

                MessageBox.Show(Control.deleting(Media));

                clear();
            }
        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            //If type isn't a number either backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Canceling the event
                e.Handled = true;
            }
        }

        private void txtDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            //If type isn't a number, bars either backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 47  && e.KeyChar != 08)
            {
                //Canceling the event
                e.Handled = true;
            }
        }

        private void txtSeason_KeyPress(object sender, KeyPressEventArgs e)
        {
            //If type isn't a number either backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Canceling the event
                e.Handled = true;
            }
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            if (txtCod.Text == "")
            {
                MessageBox.Show("You must fill the cod to alter anything!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtTitle.Text == "  " || txtTitle.Text == "   ")
                {
                    MessageBox.Show("You must fill the title to alter anything!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Title
                    Media.Title_M = txtTitle.Text;

                    //Date
                    if (txtDate.Text == "")
                    {
                        //Set Null if txt is empty
                        Media.Date_M = "null";
                    }
                    else
                    {
                        Media.Date_M = ($"'{txtDate.Text}'");
                    }

                    //Season
                    if (txtSeason.Text == "")
                    {
                        //Set Null if txt is empty
                        Media.Season_M = 0;
                    }
                    else
                    {
                        Media.Season_M = Convert.ToInt32(txtSeason.Text);
                    }

                    //Season
                    if (txtSynopsis.Text == "" || txtSynopsis.Text == " ")
                    {
                        //Set Null if txt is empty
                        Media.Synopsis_M = "null";
                    }
                    else
                    {
                        Media.Synopsis_M = ($"'{txtSynopsis.Text}'");
                    }

                    MessageBox.Show(Control.altering(Media));

                    clear();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Media = Control.searching(int.Parse(txtCod.Text));

                if (Media is null)
                {
                    MessageBox.Show("Resgister not found!");
                    clear();
                }
                else
                {
                    txtCod.Text = Media.Cod_M.ToString();
                    txtTitle.Text = Media.Title_M;
                    txtDate.Text = Media.Date_M;
                    txtSeason.Text = Media.Season_M.ToString();
                    txtSynopsis.Text = Media.Synopsis_M;

                    btnAlter.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            if (txtCod.Text == "")
            {
                btnAlter.Enabled = false;
                btnDelete.Enabled = false;
                btnSearch.Enabled = false;
            }
            else
            {
                if (txtTitle.Text != "" && txtDate.Text != "")
                {
                    btnAlter.Enabled = true;
                }
                btnSearch.Enabled = true;
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            if (txtTitle.Text != "" && txtTitle.Text != " ")
            {
                btnRegister.Enabled = true;
            }
            else
            {
                btnRegister.Enabled = false;
            }
        }
    }
}
