using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Commerciaux
{
    [System.Serializable]
    public class ServiceCommercial
    {
        List<Commercial> lesCommerciaux;
        public ServiceCommercial()
        {
            lesCommerciaux = new List<Commercial>();
        }

        public List<Commercial> LesCommerciaux { get => lesCommerciaux; set => lesCommerciaux = value; }

        public void ajouterCommercial(Commercial c)
        {
            LesCommerciaux.Add(c);
        }

        public void ajouterNote(Commercial c, DateTime DateNote, int km)
        {
            NoteFrais unenote = new NoteTransport(DateNote, c, km);
        }

        public void ajouterNote(Commercial c, DateTime DateNote, double facture)
        {
            NoteFrais unenote = new NotesRepas(facture ,DateNote, c);
        }

        public void ajouterNote(Commercial c, DateTime DateNote, double facture, int region)
        {
            NoteFrais unenote = new NoteNuitee(facture, region, DateNote, c);
        }

        public int nbFraisNonRemboursés()
        {
            int i = 0;
            foreach (Commercial unCommercial in lesCommerciaux)
            {
                foreach (NoteFrais uneNote in unCommercial.LesNotesFrais)
                {
                    if (uneNote.getRembourser() is false)
                    {
                        i++;
                    }
                }
            }
            return i;
        }

        public void afficherLesCommerciaux()
        {
            foreach(Commercial c in lesCommerciaux)
            {
                Console.WriteLine(c);
                c.afficherSesNotes();
            }
        }
    }
}
