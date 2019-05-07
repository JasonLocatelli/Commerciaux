using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Commerciaux
{
    [System.Serializable]
    public class NoteFrais
    {
        private DateTime dateNote;
        private static int num;
        private double montantARembourser;
        private bool rembourser;
        private Commercial leCommercial;
        
        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        /// <param name="uneDateNote"></param>
        /// <param name="unCommercial"></param>
        public NoteFrais(DateTime uneDateNote, Commercial unCommercial)
        {
            num++;
            dateNote = uneDateNote;
            leCommercial = unCommercial;
            unCommercial.ajouterNoteFrais(this);
            rembourser = false;
        }

        #region Accesseur

        public void setNoteRembourse()
        {
            rembourser = true;
        }

        public bool getRembourser()
        {
            return rembourser;
        }

        public DateTime DateNote { get => dateNote; set => dateNote = value; }
        
        public Commercial LeCommercial { get => leCommercial; set => leCommercial = value; }
        public static int Num { get => num; set => num = value; }

        virtual public double getMontantARembourser()
        {
            return montantARembourser;
        }

        public void setMontantARembourser()
        {
            this.montantARembourser = calculMontantARembourser();
        }
        #endregion

        virtual public double calculMontantARembourser()
        {
            return calculMontantARembourser();
        }

        public override string ToString()
        {
            return "Date :" + dateNote + " ; Montant à rembourser " 
                + montantARembourser + " euros ; " + aRembourser();
        }

        public string aRembourser()
        {
            if (rembourser)
            {
                return "Remboursé";
            }
            else
            {
                return "Non remboursé";
            }
        }
        
    }
}
