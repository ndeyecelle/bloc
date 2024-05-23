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
    public partial class FormClasse : Form
    {
        gestion_scolaireEntities1 context = new gestion_scolaireEntities1();
       
        public FormClasse()
        {
            InitializeComponent();

        }

        private void btnclasse_Click(object sender, EventArgs e)
        {
            classe c = new classe();
            c.libelle = cmbniveau.Text + cmbspecialite.Text;
            c.especialite = cmbspecialite.Text;
            c.niveau = cmbniveau.Text;

            context.classe.Add(c);
            context.SaveChanges();

            MessageBox.Show("classe enregistrer");
            dataclasse.DataSource = context.classe.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formreport fr = new formreport();
            fr.Show();
              
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
