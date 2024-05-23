using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.Windows.Forms;

namespace Projet_School
{
    public partial class formreport : Form
    {
        private object ds;

        public formreport()
        {
            InitializeComponent();
        }


       

        private void formrapport_Load(object sender, EventArgs e)


        {



            






        }

        private void viwerscripteur_Load(object sender, EventArgs e)
        {
           
            monrapport2 report = new monrapport2();
            report.setDataSource(ds);
            monrapport1.reportSource = report;


        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlrecherche_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnrecherche_Click(object sender, EventArgs e)
        {
           formreport fr = new formreport();
            fr.Show();
            
        }
    }
}
 