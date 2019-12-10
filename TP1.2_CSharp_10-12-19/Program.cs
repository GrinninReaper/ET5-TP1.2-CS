using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1._2_CSharp_10_12_19
{
    class Program
    {
        static void Main(string[] args)
        {

            Chaise c = new Chaise(3, 4);
            c.SeDecrire();
            Table t = new Table(100, 200);
            t.SeDecrire();
            Bouteille b = new Bouteille(150);
            b.SeDecrire();

            Sac s = new Sac();
            s.Add(c);
            s.Add(t);
            s.Add(b);
            s.SeDecrire();

            Salle salle = new Salle("Chambre d'opération");
            salle.SeDecrire();
        }
    }
}
