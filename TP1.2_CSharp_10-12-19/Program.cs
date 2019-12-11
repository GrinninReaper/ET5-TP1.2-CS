using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1._2_CSharp_10_12_19
{
    class Program
    {
        static void DisplayControls()
        {
            Console.WriteLine("");
            Console.WriteLine("What do you wanna do?");
            Console.WriteLine("-b: Display content of bag");
            Console.WriteLine("-cr: Display content of room");
            Console.WriteLine("-r: Display room description");
            Console.WriteLine("-m: Move to another room");
            Console.WriteLine("-t: Take content of the room in bag");
            Console.WriteLine("-x: Exit the game");
        }

        static void Main(string[] args)
        {
            int nbOfRooms = 10;
            ArrayList possibleDest = new ArrayList();
            possibleDest.Add("N");
            possibleDest.Add("E");
            possibleDest.Add("O");
            possibleDest.Add("S");
            Console.WriteLine("Generating the labyrinth...");
            Labyrinthe dedale = new Labyrinthe(nbOfRooms);
            dedale.SeDecrire();

            bool stopRun = false;
            while (!stopRun)
            {
                DisplayControls();
                String response = Console.ReadLine();
                switch (response)
                {
                    case "b":
                        dedale.player.SeDecrire();
                        break;
                    case "cr":
                        dedale.player.seTrouveDans.SeDecrire();
                        break;
                    case "r":
                        Console.Write("I'm located in room :");
                        Console.WriteLine(dedale.player.seTrouveDans.nom);
                        break;
                    case "m":
                        Console.WriteLine("Where do you wanna go?");
                        Console.WriteLine("You can go to:");
                        for(int i = 0; i < dedale.player.seTrouveDans.issueList.Count; i++)                        
                            Console.WriteLine(possibleDest[i]);
                        String destination = Console.ReadLine();
                        int dest = 0;
                        switch (destination)
                        {
                            case "N":
                                dest = 1;
                                break;
                            case "E":
                                dest = 2;
                                break;
                            case "O":
                                dest = 3;
                                break;
                            case "S":
                                dest = 4;
                                break;
                        }
                        dedale.player.AllerVers(dest);
                        break;
                    case "t":
                        dedale.player.PrendreTout();
                        break;
                    case "x":
                        Console.WriteLine("Exiting program");
                        stopRun = true;
                        break;
                    default:
                        Console.WriteLine("Unknown command. Try again.");
                        break;
                }

            }
            /*
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
            */
        }
    }
}
