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
    public partial class FrmvisualiserLesNotes : Form
    {
        private ServiceCommercial leService;
        public FrmvisualiserLesNotes(ServiceCommercial leService)
        {
            this.leService = leService;
            InitializeComponent();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
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

        private void chargerListeNotes(Commercial c)
        {
            if (leService != null)
            {
                lbNotesFrais.Items.Clear();
                foreach (NoteFrais uneNote in c.LesNotesFrais)
                {
                    lbNotesFrais.Items.Add(uneNote.ToString());
                }
            }
        }

        private void FrmvisualiserLesNotes_Load(object sender, EventArgs e)
        {
            

            if (leService != null)
            {
                chargerListeCommerciaux();
                chargerListeNotes(leService.LesCommerciaux[lbCommerciaux.SelectedIndex]);
            }
        }

        private void lbCommerciaux_SelectedIndexChanged(object sender, EventArgs e)
        {
            chargerListeNotes(leService.LesCommerciaux[lbCommerciaux.SelectedIndex]);
        }
    }
}
