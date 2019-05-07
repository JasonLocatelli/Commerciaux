using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP_Commerciaux;

namespace unTestUnitaire
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ajouterNoteFraisTest()
        {
            Commercial c;
            c = new Commercial("Jean", "Dupond", 25, '4');
            NoteFrais f, f1;
            f = new NoteFrais(new DateTime(2013, 11, 12), c);
            f1 = new NoteFrais(new DateTime(2013, 11, 15), c);
            Assert.AreEqual(2, c.LesNotesFrais.Count);
        }
        
            [TestMethod]
        public void nbNotesFraisNonRembourseesTest()
        {
            Commercial c, c1;
            ServiceCommercial sc;
            sc = new ServiceCommercial();
            c = new Commercial("Jean", "Dupond", 25, 'A');
            c1 = new Commercial("Paul", "Duval", 10, 'B');
            sc.ajouterCommercial(c);
            sc.ajouterCommercial(c1);
            NoteFrais f, f1, f2, f3, f4;
            f = new NoteFrais(new DateTime(2013, 11, 12), c);
            f1 = new NoteFrais(new DateTime(2013, 11, 15), c);
            f1.setNoteRembourse();
            f2 = new NoteFrais(new DateTime(2013, 11, 18), c1);
            f3 = new NoteFrais(new DateTime(2013, 11, 22), c1);
            f3.setNoteRembourse();
            f4 = new NoteFrais(new DateTime(2013, 11, 25), c1);
            f4.setNoteRembourse();
            Assert.AreEqual(2, sc.nbFraisNonRemboursés());
        }

        [TestMethod]
        public void calculMontantARembourserTransportTest()
        {
            Commercial c;
            c = new Commercial("Jean", "Dupond", 8, 'A');
            NoteFrais f;
            f = new NoteTransport(new DateTime(2013, 11, 12), c, 250);
            Assert.AreEqual(f.getMontantARembourser(), 50);
        }

        [TestMethod]
        public void calculMontantARembourserNuiteeTest()
        {
            Commercial c;
            c = new Commercial("Jean", "Dupond", 8, 'A');
            NoteFrais f;
            f = new NoteNuitee(46,2,new DateTime(2013, 11, 12), c);
            Assert.AreEqual(f.getMontantARembourser(), 46);

            Commercial c1;
            c1 = new Commercial("Jean", "Dupond", 8, 'A');
            NoteFrais f1;
            f1 = new NoteNuitee(80, 3, new DateTime(2013, 11, 12), c);
            Assert.AreEqual(f1.getMontantARembourser(), 74.75);
        }

        [TestMethod]
        public void calculMontantARembourserRepasTest()
        {
            Commercial c;
            c = new Commercial("Jean", "Dupond", 8, 'A');
            NoteFrais f;
            f = new NotesRepas(35, new DateTime(2013, 11, 12), c);
            Assert.AreEqual(f.getMontantARembourser(), 25);

            Commercial c1;
            c1 = new Commercial("Jean", "Dupond", 8, 'A');
            NoteFrais f1;
            f1 = new NotesRepas(15, new DateTime(2013, 11, 12), c);
            Assert.AreEqual(f1.getMontantARembourser(), 15);
        }

        [TestMethod]
        public void testServiceCo()
        {
            ServiceCommercial sc;
            Commercial c1;
            sc = new ServiceCommercial();
            c1 = new Commercial("Dupond", "Jean", 7, 'B');
            sc.ajouterCommercial(c1);
            sc.ajouterNote(c1, new DateTime(2013, 11, 15), 100); // ajoute un frais de transport 
            sc.ajouterNote(c1, new DateTime(2013, 11, 21), 15.5); // ajoute une note de repas 
            sc.ajouterNote(c1, new DateTime(2013, 11, 25), 105, 2); // ajoute une nuitée 
            Assert.AreEqual(sc.nbFraisNonRemboursés(), 3);
        }

        [TestMethod]
        public void CalculMontantARembourserTest()
        {
            Commercial c = new Commercial("Darius", "Kugel", 9, 'C');
            Commercial c1 = new Commercial("Hamid", "Lekbouri", 11, 'B');
            Commercial c2 = new Commercial("René", "Belardi", 4, 'A');

            NoteFrais f1 = new NoteTransport(new DateTime(2015, 12, 03), c, 200);
            Assert.AreEqual(40, f1.getMontantARembourser());
            NoteFrais f2 = new NoteTransport(new DateTime(2015, 12, 03), c1, 200);
            Assert.AreEqual(60, f2.getMontantARembourser());
            NoteFrais f3 = new NoteTransport(new DateTime(2015, 12, 03), c2, 200);
            Assert.AreEqual(20, f3.getMontantARembourser());

            NoteFrais f4 = new NotesRepas(35, new DateTime(2015, 10, 23), c);
            Assert.AreEqual(20, f4.getMontantARembourser());
            NoteFrais f5 = new NotesRepas(18, new DateTime(2015, 10, 23), c);
            Assert.AreEqual(18, f5.getMontantARembourser());

            NoteFrais f6 = new NotesRepas(15, new DateTime(2015, 10, 23), c1);
            Assert.AreEqual(15, f6.getMontantARembourser());
            NoteFrais f7 = new NotesRepas(25, new DateTime(2015, 10, 23), c1);
            Assert.AreEqual(22, f7.getMontantARembourser());

            NoteFrais f8 = new NotesRepas(28, new DateTime(2015, 10, 23), c2);
            Assert.AreEqual(25, f8.getMontantARembourser());
            NoteFrais f9 = new NotesRepas(18, new DateTime(2015, 10, 23), c2);
            Assert.AreEqual(18, f9.getMontantARembourser());



            NoteFrais f10 = new NoteNuitee(46, 2, new DateTime(2015, 10, 23), c);
            Assert.AreEqual(46, f10.getMontantARembourser());
            NoteFrais f11 = new NoteNuitee(56, 3, new DateTime(2015, 10, 23), c);
            Assert.AreEqual(56, f11.getMontantARembourser());
            NoteFrais f12 = new NoteNuitee(46, 1, new DateTime(2015, 10, 23), c);
            Assert.AreEqual(45, f12.getMontantARembourser());

            NoteFrais f13 = new NoteNuitee(60, 2, new DateTime(2015, 10, 23), c1);
            Assert.AreEqual(60, f13.getMontantARembourser());
            NoteFrais f14 = new NoteNuitee(60, 3, new DateTime(2015, 10, 23), c1);
            Assert.AreEqual(60, f14.getMontantARembourser());
            NoteFrais f15 = new NoteNuitee(50, 1, new DateTime(2015, 10, 23), c1);
            Assert.AreEqual(49.5, f15.getMontantARembourser());

            NoteFrais f16 = new NoteNuitee(76, 2, new DateTime(2015, 10, 23), c2);
            Assert.AreEqual(71.5, f16.getMontantARembourser());
            NoteFrais f17 = new NoteNuitee(80, 3, new DateTime(2015, 10, 23), c2);
            Assert.AreEqual(74.75, f17.getMontantARembourser());
            NoteFrais f18 = new NoteNuitee(46, 1, new DateTime(2015, 10, 23), c2);
            Assert.AreEqual(46, f18.getMontantARembourser());
        }

    }
}
