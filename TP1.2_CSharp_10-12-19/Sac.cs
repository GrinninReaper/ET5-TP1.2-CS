using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1._2_CSharp_10_12_19
{
    class Sac
    {

        public ArrayList contenue;

        public Sac()
        {
            contenue = new ArrayList();
        }

        public void SeDecrire()
        {
            if (contenue.Count == 0)
                Console.WriteLine("nothing");
            else
            {
                foreach (Materiel obj in contenue)
                {
                    obj.SeDecrire();
                }
            }
            
        }

        public void Add(Materiel m)
        {
            contenue.Add(m);
        }
    }
}
