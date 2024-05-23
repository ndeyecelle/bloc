using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_School
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cRUDCLASSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClasse fr = new FormClasse();
            fr.Show();
        }

        private void cRUDETUDIANTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEtudiant fe = new FormEtudiant();
            fe.Show();
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void monrapportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listesDesClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eTUDIANTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cLASSEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click_1(object sender, EventArgs e)
        {
            
            
            
        }

        private void btnimprimer_Click(object sender, EventArgs e)
        {
            formreport fr = new formreport();
            fr.Show();
        }
    }
}
