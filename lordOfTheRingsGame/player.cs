using System;
using System.Diagnostics;

namespace lordOfTheRingsGame
{
    public class player
    {
        public string name = "HAH";
        public string race = "Human";


        public void Continue() {
            Console.WriteLine("Stiskněte libovolnou klávesu . . .");
            Console.ReadKey();
            Console.Clear();
        }

        public void Chooserace()
        {
            bool validRace = false;
            while (!validRace)
            {
                string raceInput = Console.ReadLine();

                if (raceInput == "1")
                {
                    race = "Člověk";
                    validRace = true;
                }
                else if (raceInput == "2")
                {
                    race = "Elf";
                    validRace = true;
                }
                else
                {
                    Console.WriteLine("Neplatná volba rasy. Prosím, vyberte 1 pro Člověka nebo 2 pro Elfa.");
                }
            }
        }
    }
}