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
    public partial class Form1 : Form
    {
        private ServiceCommercial leService;
        private string nomFichier;

        public string NomFichier { get => nomFichier; set => nomFichier = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            nomFichier = openFileDialog1.FileName;
            leService = PersisteCommercial.charge(nomFichier);
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(nomFichier != null)
            {
                PersisteCommercial.sauve(leService, nomFichier);
            }
            else
            {
                MessageBox.Show("Ouvrez un fichier pour pouvoir l'enregistrer");
            }
        }

        private void nouveauCommercialToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            if (leService != null)
            {
                FmAjoutCommercial f = new FmAjoutCommercial(this.leService);
                f.Show();
            }
            else
            {
                MessageBox.Show("Aucun service n'a été ouvert");
            }
        }

        private void nouvelleNoteDeFraisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (leService != null)
            {
                FrmnouvelleNoteDeFrais f = new FrmnouvelleNoteDeFrais(this.leService);
                f.Show();
            }
            else
            {
                MessageBox.Show("Aucun service n'a été ouvert");
            }
        }

        private void visualiserLesNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (leService != null)
            {
                FrmvisualiserLesNotes f = new FrmvisualiserLesNotes(this.leService);
                f.Show();
            }
            else
            {
                MessageBox.Show("Aucun service n'a été ouvert");
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
