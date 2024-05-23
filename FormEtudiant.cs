using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_School
{
    public partial class FormEtudiant : Form
    {
        gestion_scolaireEntities1 context = new gestion_scolaireEntities1();
        public FormEtudiant()
        {
            InitializeComponent();
            cmbclasse.DataSource = context.classe.ToList();
            cmbclasse.DisplayMember = "libelle";
            cmbclasse.ValueMember = "id";
            dataetudiant.DataSource = context.etudiant.ToList();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnetudiant_Click(object sender, EventArgs e)
        {
            etudiant et = new etudiant();
            et.prenom = txtprenom.Text;
            et.nom = txtnom.Text;
            et.credit = int.Parse(txtcredit.Text);
            et.reglement = txtreglement.Text;
            et.anneescolaire = txtenneeescolaire.Text;
            et.idclasse = Convert.ToInt32(cmbclasse.SelectedValue);
            context.etudiant.Add(et);
            context.SaveChanges();
            MessageBox.Show("etudiant enreristrer");
            dataetudiant.DataSource = context.etudiant.ToList();
        }

        private void FormEtudiant_Load(object sender, EventArgs e)
        {

        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            int idEtudiant;
            if (int.TryParse(txtid.Text, out idEtudiant))
            {
                var et = context.etudiant.FirstOrDefault(etudiant => etudiant.id == idEtudiant);


                if (et != null)
                {
                    et.prenom = txtprenom.Text;
                    et.nom = txtnom.Text;
                  
                    et.reglement = txtreglement.Text;
                    et.anneescolaire = txtenneeescolaire.Text;
                    et.idclasse = Convert.ToInt32(cmbclasse.SelectedValue);

                    context.SaveChanges();
                    MessageBox.Show("Étudiant modifié");
                }
                else
                {
                    MessageBox.Show("Étudiant introuvable");
                }


                dataetudiant.DataSource = context.etudiant.ToList();
            }
            else
            {
                MessageBox.Show("ID invalide");
            }

        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            if (dataetudiant.SelectedRows.Count > 0)
            {

                int idEtudiant = (int)dataetudiant.SelectedRows[0].Cells["id"].Value;


                var et = context.etudiant.FirstOrDefault(etudiant => etudiant.id == idEtudiant);

                if (et != null)
                {
                    context.etudiant.Remove(et);
                    context.SaveChanges();
                    MessageBox.Show("Étudiant supprimé");
                }
                else
                {
                    MessageBox.Show("Étudiant introuvable");
                }


                dataetudiant.DataSource = context.etudiant.ToList();
            }
            else
            {
                MessageBox.Show("Aucun étudiant sélectionné");
            }
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            txtprenom.Text = "";
            txtnom.Text = "";
            txtcredit.Text = "";
            txtreglement.Text = "";
            txtenneeescolaire.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idEtudiant;
            if (int.TryParse(txtrechid.Text, out idEtudiant))
            {
                var etr = context.etudiant.Find(idEtudiant);
                if (etr != null)
                {
                    txtid.Text = Convert.ToString(etr.id);
                    txtprenom.Text = etr.prenom;
                    txtnom.Text = etr.nom;
                    txtcredit.Text = Convert.ToString(etr.credit);
                    txtreglement.Text = Convert.ToString(etr.reglement);
                    txtenneeescolaire.Text = etr.anneescolaire;
                    var classes = context.classe.Find(etr.idclasse);
                    cmbclasse.Text = classes.libelle;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            formreport fr = new formreport();
            fr.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnrechclasse_Click(object sender, EventArgs e)
        {
            string nomclasse = Convert.ToString(btnrechclasse.Text);
            int idclasse = context.classe.Where(cl => cl.libelle == nomclasse).
                Select(cl => cl.id).FirstOrDefault();
            if(idclasse != 0)
            {
                var etus = context.etudiant.
                    Where(et => et.idclasse == idclasse).ToList();
                dataetudiant.DataSource = etus;

            }

            var classe = context.classe.Find(idclasse);


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbclasse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnrechetudiant_Click(object sender, EventArgs e)
        {
            string an = Convert.ToString(btnrechannee.Text).ToString();
            var etus = context.etudiant.Where(et => et.anneescolaire == an).ToList();

            dataetudiant.DataSource = etus;







        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtcredit_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtenneeescolaire_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }

    internal class btnetudiant
    {
    }
}

