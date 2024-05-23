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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = "Mandiaye";
            string password = "saliou96";

            // Demande à l'utilisateur de saisir son nom d'utilisateur
            Console.Write("Mandiaye : ");
            string inputUsername = Console.ReadLine();

            // Demande à l'utilisateur de saisir son mot de passe
            Console.Write("saliou96 : ");
            string inputPassword = Console.ReadLine();

            // Vérification des informations de connexion
            if (inputUsername == username && inputPassword == password)
            {
                Console.WriteLine("Connexion réussie !");
                Form1 mForm = new Form1();
                mForm.Show();
                this.Hide();
            }
            else
            {
                Console.WriteLine("Nom d'utilisateur ou mot de passe incorrect !");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

