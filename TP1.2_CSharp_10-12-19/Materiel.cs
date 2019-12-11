using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1._2_CSharp_10_12_19
{
    abstract class Materiel:Descriptible
    {

        public virtual void SeDecrire()
        {
            Console.WriteLine("An unkown materiel");
        }

    }
}
