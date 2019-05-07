using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Commerciaux;

namespace WF_Commerciaux
{
    public partial class FmAjoutCommercial : Form
    {
        ServiceCommercial leService;
        public FmAjoutCommercial(ServiceCommercial unService)
        {
            leService = unService;
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (tbNom.Text != "" && tbPrenom.Text != "")
            {

                char categorie = 'A';
                string nom = tbNom.Text;
                string prenom = tbPrenom.Text;
                if (rbA.Checked)
                {
                    categorie = 'A';
                }
                else if (rbB.Checked)
                {
                    categorie = 'B';
                }
                else if (rbC.Checked)
                {
                    categorie = 'C';
                }
                leService.ajouterCommercial(new Commercial(tbPrenom.Text, tbNom.Text, Convert.ToInt32(nupPv.Value), categorie));
                Form.ActiveForm.Close();
                MessageBox.Show("Le commercial " + prenom + " " + nom + " a été ajouté !");
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
        }
    }
}
