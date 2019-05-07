using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Commerciaux
{
    [System.Serializable]
    public class NoteNuitee : NoteFrais
    {
        private int region;
        private double montantARembourser = 0;
        private double prixFacture;


        public NoteNuitee(double unPrixFacture, int uneRegion, DateTime dateNote, Commercial unCommercial)
                : base(dateNote, unCommercial)
        {
            region = uneRegion;
            prixFacture = unPrixFacture;
            setMontantARembourser();
        }

        public override double calculMontantARembourser()
        {
            double montant = 0;

            if (prixFacture < 50)
            {
                montant = prixFacture;
            }
            else if (LeCommercial.Cat == 'A')
            {
                montant = 65;
            }
            else if (LeCommercial.Cat == 'B')
            {
                montant = 55;
            }
            else if (LeCommercial.Cat == 'C')
            {
                montant = 50;
            }

            if (region == 1 && prixFacture >= 50)
            {
                montant = montant * 0.9;
            }
            else if (region == 3 && prixFacture >= 50)
            {
                montant = montant * 1.15;
            }

            return montant;
        }

        public override String ToString()
        {
            return "Nuitee - " + base.ToString() + "- prix de la facture : " + prixFacture + " - region : " + region;
        }
    }
}
