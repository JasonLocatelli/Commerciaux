using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Commerciaux
{
    class Program
    {
        static void Main(string[] args)
        {
            //Commercial c;
            //c = new Commercial("Jean", "Dupond", 25, 'A');
            //Console.WriteLine(c.ToString()); //on pourrait aussi écrire Console.WriteLine(c);
            //NoteFrais f;
            //f = new NoteFrais(new DateTime(2013, 11, 12), c);
            //Console.WriteLine(f.ToString());

            //ServiceCommercial sc;
            //Commercial c1;
            //sc = new ServiceCommercial();
            //c1 = new Commercial("Dupond", "Jean", 7, 'B');
            //sc.ajouterCommercial(c1);
            //sc.ajouterNote(c1, new DateTime(2013, 11, 15), 100); // ajoute un frais de transport 
            //sc.ajouterNote(c1, new DateTime(2013, 11, 21), 15.5); // ajoute une note de repas 
            //sc.ajouterNote(c1, new DateTime(2013, 11, 25), 105, 2); // ajoute une nuitée 

            // test de la méthode ToString des différents frais
            //Commercial c2 = new Commercial("Darius", "Kugel", 9, 'A');
            //Commercial c3 = new Commercial("Hamid", "Lekbouri", 11, 'B');
            //NoteFrais f1 = new NoteTransport(new DateTime(2015, 12, 03), c2, 200);
            //NoteFrais f2 = new NotesRepas(15, new DateTime(2015, 10, 23), c3);
            //NoteFrais f3 = new NoteNuitee(56, 3, new DateTime(2015, 10, 23), c2);
            //Console.WriteLine(f1.ToString());
            //Console.WriteLine(f2.ToString());
            //Console.WriteLine(f3.ToString());

            //Console.WriteLine("Appuyez sur une touche pour continuer ...");


            ServiceCommercial sc = new ServiceCommercial();
            Commercial c = new Commercial("Jean", "Dupont", 7, 'B');
            sc.ajouterCommercial(c);
            sc.ajouterNote(c, new DateTime(2014, 10, 23), 100);
            sc.ajouterNote(c, new DateTime(2014, 10, 24), 15.5);
            sc.ajouterNote(c, new DateTime(2014, 10, 25), 105, 2);

            Commercial c1 = new Commercial("Baptiste", "Trodoux", 2, 'A');
            sc.ajouterCommercial(c1);
            sc.ajouterNote(c1, new DateTime(2018, 1, 23), 500);
            sc.ajouterNote(c1, new DateTime(2018, 2, 24), 10.5);
            sc.ajouterNote(c1, new DateTime(2018, 3, 25), 145, 1);

            // le fichier est au même niveau que l'exécutable dans /bin/debug ...
            PersisteCommercial.sauve(sc, "service.sr1");



           ServiceCommercial sc1 = PersisteCommercial.charge("service.sr1");
           sc1.afficherLesCommerciaux(); // méthode affichant les infos de chaque employé

            Console.ReadLine();
            
        }
    }
}
