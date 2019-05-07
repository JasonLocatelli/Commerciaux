using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TP_Commerciaux;

namespace TP_Commerciaux
{
    public class PersisteCommercial
    {
        public static void sauve(ServiceCommercial sc, string nomFichier)
        {
            FileStream fichier = new FileStream(nomFichier, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fichier, sc);
            fichier.Close();
        }

        public static ServiceCommercial charge(string nomFichier)
        {
            FileStream fichier = new FileStream(nomFichier, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            ServiceCommercial sc = (ServiceCommercial)bf.Deserialize(fichier);
            fichier.Close();
            return sc;
        }
    }
}
