using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1._2_CSharp_10_12_19
{
    class Labyrinthe : Descriptible
    {

        public Robot player;
        public ArrayList listSalle;
        
        public Labyrinthe(int nbSalle)
        {
            player = new Robot();
            listSalle = new ArrayList();
            var rand = new Random();
            //Création des salle
            for (int i = 0; i < nbSalle; i++)
            {
                ArrayList possession = new ArrayList();
                ArrayList listIssue = new ArrayList();
                int nbOfMateriel = (int)rand.NextDouble() * 3 ;
                for (int j = 0; j < 3; j++)
                {
                    int type = (int) (rand.NextDouble() * 3 + 1);
                    switch (type)
                    {
                        case 1:
                            Bouteille bout = new Bouteille(150);
                            possession.Add(bout);
                            break;
                        case 2:
                            Chaise chair = new Chaise(3, 4);
                            possession.Add(chair);
                            break;
                        case 3:
                            Table table = new Table(150, 150);
                            possession.Add(table);
                            break;
                        default:
                            break;
                    }
                }
                
                Salle salleTemp = new Salle("Salle" + i, listIssue, possession);
                listSalle.Add((Salle) salleTemp);
            }
            for(int l = 0; l < nbSalle; l++)
            {
                Salle s = (Salle) listSalle[l];
                ArrayList alreadyPresentIssues = new ArrayList();
                int nbOfIssues = (int)(rand.NextDouble() * 4 + 1);
                for (int k = 0; k < nbOfIssues; k++)
                {
                    int arrive = (int)(rand.NextDouble() * (nbSalle));
                    while (arrive == l || alreadyPresentIssues.Contains(arrive))
                    {
                        arrive = (int)(rand.NextDouble() * (nbSalle));
                    }
                    Issue issueTemp = new Issue(s, (Salle)listSalle[arrive], 0);
                    s.issueList.Add(issueTemp);
                    alreadyPresentIssues.Add(arrive);
                }
            }
            //placement du robot dans le labyrtinthe
            player.seTrouveDans = (Salle) listSalle[0];
        }

        public void SeDecrire()
        {
            Console.WriteLine("Description of the labyrinth");
            foreach(Salle s in listSalle)
            {
                s.SeDecrire();
            }
            Console.WriteLine("");
            player.SeDecrire();
        }

    }
}
