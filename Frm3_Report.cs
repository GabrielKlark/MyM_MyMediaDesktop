using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;
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
    public partial class Frm3_Report : Form
    {
        cl_ConnectionMySQL db = new cl_ConnectionMySQL();
        cl_Media Media = new cl_Media();
        cl_ControlMedia Control = new cl_ControlMedia();
        public Frm3_Report()
        {
            InitializeComponent();
        }

        private void Frm3_Report_Load(object sender, EventArgs e)
        {
            //string sqlCmd = "select cod_M as 'Code', title_M as 'Title', date_M as 'Date', season_M as 'Num Seasons', synopsis_M as 'Synopsis' from tb_Media;";
            string sqlCmd = "select * from tb_Media;";

            MySqlDataAdapter da = new MySqlDataAdapter(sqlCmd, db.con);

            dsM ds = new dsM();

            da.Fill(ds.Tables["tb_Media"]);

            ReportDocument cr = new ReportDocument();
            cr = new crM();
            cr.SetDataSource(ds);

            crystalReportViewer1.ReportSource = cr;

            ReportDocument cryRpt = new ReportDocument();

            /*
            string sqlCmd = "select * from tbMed;";

            MySqlDataAdapter da = new MySqlDataAdapter(sqlCmd, @"Server=localhost;Port=3306;Database=bdCryRpt;User=root;Pwd=gislaine");

            dsMed ds = new dsMed();
            da.Fill(ds.Tables["tbMed"]);
            ReportDocument cr = new ReportDocument();
            cr = new cr_M();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
            ReportDocument cryRpt = new ReportDocument();
            */
        }

        private void Frm3_Report_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.disconnect();
        }
    }
}
