using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Commerciaux
{
    [System.Serializable]
    public class Commercial
    {
        private string nom;
        private string prenom;
        private char cat;
        private int puissance;
        private List<NoteFrais> lesNotesFrais;


        public Commercial(string unPrenom, string unNom, int unePuissance, char uneCat)
        {
            nom = unNom;
            prenom = unPrenom;
            cat = uneCat;
            puissance = unePuissance;
            lesNotesFrais = new List<NoteFrais>();
        }

        #region Accesseur

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public char Cat { get => cat; set => cat = value; }
        public int Puissance { get => puissance; set => puissance = value; }
        public List<NoteFrais> LesNotesFrais { get => lesNotesFrais; set => lesNotesFrais = value; }

        #endregion

        public void ajouterNoteFrais(NoteFrais f)
        {
            lesNotesFrais.Add(f);
        }

        public override string ToString()
        {
            return "Prenom : " + Prenom + " ; Nom : " + Nom + " ; Puissance voiture : " + Puissance +
                " ; catégorie " + Cat;
        }

        public double cumulNoteFrais(int annee)
        {
            double montant = 0;
            foreach (NoteFrais uneNote in lesNotesFrais)
            {
                if (uneNote.DateNote.Year == annee)
                {
                    montant += uneNote.calculMontantARembourser();
                }
            }
            return montant;
        }

        public void afficherSesNotes()
        {
            foreach(NoteFrais n in lesNotesFrais)
            {
                Console.WriteLine(n);
            }
        }
    }
}

