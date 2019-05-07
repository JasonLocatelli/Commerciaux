using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TP_Commerciaux
{
    [System.Serializable]
    public class NotesRepas : NoteFrais
    {
        private double montantARembourser = 0;
        private double prixFacture;

        public NotesRepas(double unPrixFacture, DateTime dateNote, Commercial unCommercial)
                : base(dateNote, unCommercial)
        {
            prixFacture = unPrixFacture;
            setMontantARembourser();
        }
        public override double calculMontantARembourser()
        {
            double montant = 0;
            if (prixFacture < 20)
            {
                montant = prixFacture;
            }
            else if (LeCommercial.Cat == 'A')
            {
                montant = 25;
            }
            else if (LeCommercial.Cat == 'B')
            {
                montant = 22;
            }
            else if (LeCommercial.Cat == 'C')
            {
                montant = 20;
            }
            return montant;
        }

        public override String ToString()
        {
            return "Repas - " + base.ToString() + "- prix de la facture : " + prixFacture;
        }
    }
}
