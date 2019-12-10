using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1._2_CSharp_10_12_19
{
    class Robot : Descriptible
    {

        public Salle seTrouveDans;
        private Sac sac;

        public Robot()
        {
            sac = new Sac();
        }

        public void AllerVers(int destination)
        {

        }

        private void DecrireMateriel()
        {
            sac.SeDecrire();
        }

        public void PrendreTout()
        {
            seTrouveDans.MettreMaterielDans(sac);
        }

        public void SeDecrire()
        {
            Console.WriteLine("Le robot se trouve: ");
            seTrouveDans.SeDecrire();
        }

    }
}
