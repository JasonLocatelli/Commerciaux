using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Commerciaux;
using System.Windows.Forms;

namespace WF_Commerciaux
{
    public partial class FrmnouvelleNoteDeFrais : Form
    {
        private ServiceCommercial leService;

        public FrmnouvelleNoteDeFrais(ServiceCommercial unService)
        {
            leService = unService;
            InitializeComponent();
        }

        private void chargerListeCommerciaux()
        {
            if (leService != null)
            {
                foreach (Commercial c in this.leService.LesCommerciaux)
                {
                    string nom = c.Nom;
                    string prenom = c.Prenom;
                    this.lbCommerciaux.Items.Add(nom + " " + prenom);
                }
                this.lbCommerciaux.SelectedIndex = 0;     // sélection par défaut du premier
            }
        }

        private void rbTransport_CheckedChanged(object sender, EventArgs e)
        {
            Transport.Visible = !Transport.Visible;
        }

        private void rbRepas_CheckedChanged(object sender, EventArgs e)
        {
            Repas.Visible = !Repas.Visible;
        }

        private void rbNuite_CheckedChanged(object sender, EventArgs e)
        {
            Nuitee.Visible = !Nuitee.Visible;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

  

        private void FrmnouvelleNoteDeFrais_Load(object sender, EventArgs e)
        {
            chargerListeCommerciaux();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (DateTime.Today.Day >= dateTimePicker.Value.Day &&
                DateTime.Today.Month == dateTimePicker.Value.Month &&
                DateTime.Today.Year == dateTimePicker.Value.Year)
            {
                string nom = lbCommerciaux.SelectedItem.ToString().Split(' ')[0];
                string prenom = lbCommerciaux.SelectedItem.ToString().Split(' ')[1];

                if (rbNuite.Checked)
                {
                    if (rbZone1.Checked)
                    {
                        leService.ajouterNote(leService.LesCommerciaux[lbCommerciaux.SelectedIndex], dateTimePicker.Value, Convert.ToDouble(nupFactureNuitee.Value), 1);
                    }
                    if (rbZone2.Checked)
                    {
                        leService.ajouterNote(leService.LesCommerciaux[lbCommerciaux.SelectedIndex], dateTimePicker.Value, Convert.ToDouble(nupFactureNuitee.Value), 2);
                    }
                    if (rbZone3.Checked)
                    {
                        leService.ajouterNote(leService.LesCommerciaux[lbCommerciaux.SelectedIndex], dateTimePicker.Value, Convert.ToDouble(nupFactureNuitee.Value), 3);
                    }
                }

                else if (rbRepas.Checked)
                {
                    leService.ajouterNote(leService.LesCommerciaux[lbCommerciaux.SelectedIndex], dateTimePicker.Value, Convert.ToDouble(nupFactureRepas.Value));
                }

                else if (rbTransport.Checked)
                {
                    leService.ajouterNote(leService.LesCommerciaux[lbCommerciaux.SelectedIndex], dateTimePicker.Value, Convert.ToInt32(nupKmTransport.Value));
                }
                MessageBox.Show("La note de service de "+prenom+" "+nom+" a été ajouté.");
                Form.ActiveForm.Close();

            }
            else
            {
                MessageBox.Show("La date est incorrect");
            }
        }
    }
}
