using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1._2_CSharp_10_12_19
{
    class Bouteille : Materiel, Descriptible
    {

        private int volume;

        public Bouteille(int v)
        {
            volume = v;
        }

        public override void SeDecrire()
        {
            Console.WriteLine("A bottle:");
            Console.WriteLine(" volume:{0}", volume);
        }
    }
}
