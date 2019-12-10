using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1._2_CSharp_10_12_19
{
    class Issue : Descriptible { 

        private int etat;

        public Salle depart
        {
            get; set;
        }

        public Salle arrivee
        {
            get; set;
        }

        public Issue(Salle d, Salle a, int e)
        {
            depart = d;
            arrivee = a;
            etat = e;
        }

        public void SeDecrire()
        {

        }
    }
}
