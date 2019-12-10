using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1._2_CSharp_10_12_19
{
    class Labyrinthe : Descriptible
    {

        private Robot player;
        private ArrayList listSalle;


        public Labyrinthe(int nbSalle)
        {

        }

        public void SeDecrire()
        {
            player.SeDecrire();
            foreach(Salle s in listSalle)
            {
                s.SeDecrire();
            }
        }

    }
}
