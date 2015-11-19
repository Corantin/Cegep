using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EvaluateurMainTexas;

namespace tu_eval
{
    [TestFixture]
    public class Class1
    {
        Evaluateur eval = new Evaluateur();
        Carte[] laMain = new Carte[7];
        int v = 0;

        [Test]
        public void testeRien()
        {
            Evaluateur eval = new Evaluateur();
            
            laMain[0] = new Carte(0, 0);
            laMain[1] = new Carte(1, 0);
            laMain[2] = new Carte(2, 0);
            laMain[3] = new Carte(3, 0);
            laMain[4] = new Carte(4, 0);
            laMain[5] = new Carte(5, 0);
            laMain[6] = new Carte(6, 0);

            v = eval.CalculeValeurPostRiver(laMain);
            Assert.AreEqual("rien: dix, neuf, huit, cinq, quatre.",eval.ConvertEvalEnFrancais(v));

            laMain[0] = new Carte(0, 0);
            laMain[1] = new Carte(6, 0);
            laMain[2] = new Carte(7, 0);
            laMain[3] = new Carte(9, 0);
            laMain[4] = new Carte(10, 1);
            laMain[5] = new Carte(11, 1);
            laMain[6] = new Carte(12, 1);

            v = eval.CalculeValeurPostRiver(laMain);
            Assert.AreEqual("rien: As, Roi, Dame, Valet, 9", eval.ConvertEvalEnFrancais(v));
        }

        [Test]
        public void testePaire()
        {

        }

        [Test]
        public void testePaires()
        {

        }

        [Test]
        public void testeBrelan()
        {

        }


        [Test]
        public void testeSeq()
        {

        }

        [Test]
        public void testeCouleur()
        {
            

            laMain[0] = new Carte(0, 0);
            laMain[1] = new Carte(1, 0);
            laMain[2] = new Carte(2, 0);
            laMain[3] = new Carte(3, 0);
            laMain[4] = new Carte(6, 1);
            laMain[5] = new Carte(7, 1);
            laMain[6] = new Carte(8, 1);

            v = eval.CalculeValeurPostRiver(laMain);
            Assert.AreEqual("Carte haute 10, au 9, au 8, au 7, au 5", eval.ConvertEvalEnFrancais(v));

            
        }

        [Test]
        public void testeMainPleine()
        {

        }

        [Test]
        public void testeCarre()
        {

        }

        [Test]
        public void testeSeqCoul()
        {

        }
    }
}
