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
    public partial class Frm1_Watchlist : Form
    {
        cl_Media Media = new cl_Media();
        cl_ControlMedia Control = new cl_ControlMedia();

        public Frm1_Watchlist()
        {
            InitializeComponent();

            // Create theme manager
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Set form components color;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red700, Primary.Red800,
                Primary.Red300, Accent.Red700,
                TextShade.BLACK
            );
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbSelect.SelectedIndex == 0)
            {
                try
                {
                    int cod = Convert.ToInt32(txtSearch.Text);

                    dtgvWatchlist.DataSource = Control.SelectCod(cod);
                }
                catch
                {
                    MessageBox.Show("Type an integer value as code!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSearch.Clear();
                    txtSearch.Focus();
                }
            }
            else
                if (cbSelect.SelectedIndex == 1) //Title
                {
                    try
                    {
                        string title = txtSearch.Text;

                        dtgvWatchlist.DataSource = Control.SelectTitle(title);
                    }
                    catch
                    {
                        MessageBox.Show("Type something valid as title!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSearch.Clear();
                        txtSearch.Focus();
                    }
                }
                else
                    if (cbSelect.SelectedIndex == 2) //Date
                    {
                        try
                        {
                            string date = txtSearch.Text;

                            dtgvWatchlist.DataSource = Control.SelectDate(date);
                        }
                        catch
                        {
                            MessageBox.Show("Type something valid as date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtSearch.Clear();
                            txtSearch.Focus();
                        }
                    }
                    else
                        if (cbSelect.SelectedIndex == 3) //Num of Seasons
                        {
                            try
                            {
                                int season = Convert.ToInt32(txtSearch.Text);

                                dtgvWatchlist.DataSource = Control.SelectSeason(season);
                            }
                            catch
                            {
                                MessageBox.Show("Type an integer value as Number of Seasons!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtSearch.Clear();
                                txtSearch.Focus();
                            }
                        }
                        else //Synopsis
                        {
                            try
                            {
                                string synopsis = txtSearch.Text;

                                dtgvWatchlist.DataSource = Control.SelectSynopsis(synopsis);
                            }
                            catch
                            {
                                MessageBox.Show("Type a valid synopsis!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtSearch.Clear();
                                txtSearch.Focus();
                            }
                        }
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            dtgvWatchlist.DataSource = Control.SelectEverything();
        }

        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelect.SelectedIndex < 0)
            {
                txtSearch.Enabled = false;
                btnSearch.Enabled = false;
                txtSearch.Hint = "Search:";
            }
            else
            {
                txtSearch.Enabled = true;
                txtSearch.Hint = ($"Search {cbSelect.Text}:");
                txtSearch.Clear();
                txtSearch.Focus();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "" || txtSearch.Text == " ")
            {
                btnSearch.Enabled = false;
            }
            else
            {
                btnSearch.Enabled = true;
            }
        }
    }
}
