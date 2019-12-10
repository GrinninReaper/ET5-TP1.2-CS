using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1._2_CSharp_10_12_19
{
    class Salle: Descriptible
    {

        private String nom;
        private ArrayList issue;
        private ArrayList possede;

        public Salle(String n)
        {
            nom = n;
        }

        private void DecrireIssues()
        {
            foreach(Issue i in issue)
            {
                i.SeDecrire();
            }
        }

        private void DecrireMateriel()
        {
            foreach(Materiel m in possede)
            {
                m.SeDecrire();
            }
        }

        public void MettreMaterielDans(Sac s)
        {
            foreach (Materiel m in possede)
            {
                s.contenue.Add(m);
            }
            ViderMateriel();
        }

        public void SeDecrire()
        {
            Console.WriteLine();
            Console.WriteLine("Description d'une salle:");
            Console.WriteLine(" Nom: " + nom);
            Console.WriteLine("Description des issues:");
            DecrireIssues();
            Console.WriteLine("Description matériel:");
            DecrireMateriel();

        }

        private void ViderMateriel()
        {
            possede.Clear();
        }
    }
}
