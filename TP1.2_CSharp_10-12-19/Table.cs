using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1._2_CSharp_10_12_19
{
    class Table : Materiel, Descriptible
    {

        private int longueur;
        private int largeur;

        public Table(int larg, int lng)
        {
            longueur = lng;
            largeur = larg;

        }

        public override void SeDecrire()
        {
            Console.WriteLine("A table:");
            Console.WriteLine(" dimensions:{0} x {1}", longueur, largeur);
        }
    }
}
