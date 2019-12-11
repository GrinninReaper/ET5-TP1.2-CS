using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1._2_CSharp_10_12_19
{
    class Chaise : Materiel, Descriptible
    {

        private int couleur;
        private int nbPieds;

        public Chaise(int c, int n)
        {
            couleur = c;
            nbPieds = n;
        }

        public override void SeDecrire()
        {
            Console.WriteLine("A chair:");
            Console.WriteLine(" color:{0} & number of legs:{1}", couleur, nbPieds);
        }
    }
}
