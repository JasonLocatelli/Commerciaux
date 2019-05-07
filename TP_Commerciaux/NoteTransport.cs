using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TP_Commerciaux
{
    [System.Serializable]
    public class NoteTransport : NoteFrais
    {
        private double km;
        private double montantARembourser = 0;

        public NoteTransport(DateTime pDate, Commercial unCommercial, double pKm)
            : base(pDate, unCommercial)
        {
            km = pKm;
            setMontantARembourser();
        }

        public override double calculMontantARembourser()
        {
            double montant = 0;
            if (LeCommercial.Puissance < 5)
            {
                montant = km * 0.1;
            }
            else if (LeCommercial.Puissance >= 5 && LeCommercial.Puissance <= 10)
            {
                montant = km * 0.2;
            }
            else if (LeCommercial.Puissance > 10)
            {
                montant = km * 0.3;
            }
            return montant;
        }

        public override String ToString()
        {
            return "Transport - " + base.ToString() + " - " + km + " km";
        }

    }
}