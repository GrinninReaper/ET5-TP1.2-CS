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

        public String nom;
        public ArrayList issueList;
        private ArrayList possede;

        public Salle(String n, ArrayList issues, ArrayList possession)
        {
            nom = n;
            issueList = new ArrayList();
            possede = possession;
        }

        private void DecrireIssues()
        {
            foreach(Issue i in issueList)
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
            Console.WriteLine("Description of a room:");
            Console.WriteLine(" Nom: " + nom);
            Console.WriteLine("");
            Console.WriteLine("Description of the room's issue:");
            DecrireIssues();
            Console.WriteLine("");
            Console.WriteLine("The room has:");
            if (possede.Count == 0)
                Console.WriteLine("Nothing in it");
            else
                DecrireMateriel();
        }

        private void ViderMateriel()
        {
            possede.Clear();
        }
    }
}
