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

            if (destination > seTrouveDans.issueList.Count)
                Console.WriteLine("Unknown location");
            else
            {
                destination--;
                seTrouveDans = ((Issue)seTrouveDans.issueList[destination]).arrivee;
            }
            
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
            Console.Write("The robot is located in: ");
            Console.WriteLine(seTrouveDans.nom);
            Console.WriteLine("Has in its bag: ");
            this.DecrireMateriel();
        }

    }
}
