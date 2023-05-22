using System;
using System.Diagnostics;

namespace lordOfTheRingsGame
{
    public class player
    {
        public string name = "HAH";
        public string race = "Human";
        public string humanClass = "Bojovník";
        private int health = new Random().Next(50,100);

        public void Continue()
        {
            Console.WriteLine("Stiskněte libovolnou klávesu . . .");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(@"
                                 ▄███████▄    ▄████████ ███▄▄▄▄           ▄███████▄    ▄████████    ▄████████     ███        ▄████████ ███▄▄▄▄   ███    █▄                                                                                     
                                ███    ███   ███    ███ ███▀▀▀██▄        ███    ███   ███    ███   ███    ███ ▀█████████▄   ███    ███ ███▀▀▀██▄ ███    ███                                                                                    
                                ███    ███   ███    ███ ███   ███        ███    ███   ███    ███   ███    █▀     ▀███▀▀██   ███    █▀  ███   ███ ███    ███                                                                                    
                                ███    ███   ███    ███ ███   ███        ███    ███  ▄███▄▄▄▄██▀   ███            ███   ▀  ▄███▄▄▄     ███   ███ ███    ███                                                                                    
                              ▀█████████▀  ▀███████████ ███   ███      ▀█████████▀  ▀▀███▀▀▀▀▀   ▀███████████     ███     ▀▀███▀▀▀     ███   ███ ███    ███                                                                                    
                                ███          ███    ███ ███   ███        ███        ▀███████████          ███     ███       ███    █▄  ███   ███ ███    ███                                                                                    
                                ███          ███    ███ ███   ███        ███          ███    ███    ▄█    ███     ███       ███    ███ ███   ███ ███    ███                                                                                    
                               ▄████▀        ███    █▀   ▀█   █▀        ▄████▀        ███    ███  ▄████████▀     ▄████▀     ██████████  ▀█   █▀  ████████▀                                                                                     
                                                                                      ███    ███                                                                                                                                               
▀█████████▄   ▄█      ███      ▄█    █▄     ▄████████      ███    █▄        ▄███████▄     ▄████████  ▄█          ▄████████  ▄███████▄  ███▄▄▄▄      ▄████████    ▄█    █▄     ▄██████▄          ▄███████▄    ▄████████    ▄████████ ███    █▄  
  ███    ███ ███  ▀█████████▄ ███    ███   ███    ███      ███    ███      ██▀     ▄██   ███    ███ ███         ███    ███ ██▀     ▄██ ███▀▀▀██▄   ███    ███   ███    ███   ███    ███        ███    ███   ███    ███   ███    ███ ███    ███ 
  ███    ███ ███▌    ▀███▀▀██ ███    ███   ███    ███      ███    ███            ▄███▀   ███    █▀  ███         ███    █▀        ▄███▀ ███   ███   ███    █▀    ███    ███   ███    ███        ███    ███   ███    ███   ███    █▀  ███    ███ 
 ▄███▄▄▄██▀  ███▌     ███   ▀ ███    ███   ███    ███      ███    ███       ▀█▀▄███▀▄▄  ▄███▄▄▄     ███        ▄███▄▄▄      ▀█▀▄███▀▄▄ ███   ███  ▄███▄▄▄      ▄███▄▄▄▄███▄▄ ███    ███        ███    ███   ███    ███   ███        ███    ███ 
▀▀███▀▀▀██▄  ███▌     ███     ███    ███ ▀███████████      ███    ███        ▄███▀   ▀ ▀▀███▀▀▀     ███       ▀▀███▀▀▀       ▄███▀   ▀ ███   ███ ▀▀███▀▀▀     ▀▀███▀▀▀▀███▀  ███    ███      ▀█████████▀  ▀███████████ ▀███████████ ███    ███ 
  ███    ██▄ ███      ███     ███    ███   ███    ███      ███    ███      ▄███▀         ███    █▄  ███         ███    █▄  ▄███▀       ███   ███   ███    █▄    ███    ███   ███    ███        ███          ███    ███          ███ ███    ███ 
  ███    ███ ███      ███     ███    ███   ███    ███      ███    ███      ███▄     ▄█   ███    ███ ███▌    ▄   ███    ███ ███▄     ▄█ ███   ███   ███    ███   ███    ███   ███    ███        ███          ███    ███    ▄█    ███ ███    ███ 
▄█████████▀  █▀      ▄████▀    ▀██████▀    ███    █▀       ████████▀        ▀████████▀   ██████████ █████▄▄██   ██████████  ▀████████▀  ▀█   █▀    ██████████   ███    █▀     ▀██████▀        ▄████▀        ███    █▀   ▄████████▀  ████████▀  
                                                                                                    ▀                                                                                                                                          
");
        }

        public void Damage(int dmg)
        {
            health -= dmg;
        }

        public int GetHealth()
        {
            return health;
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
                else
                if (raceInput == "2")
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
        public void Chooseclass()
        {
            bool validr = false;
            while (!validr)
            {
                string raceInput = Console.ReadLine();

                if (raceInput == "1")
                {
                    humanClass = "Bojovník";
                    validr = true;
                }
                else
                if (raceInput == "2")
                {
                    humanClass = "Jízda na Koni";
                    validr = true;
                }
                else
                {
                    Console.WriteLine("Neplatná volba třídy. Prosím, vyberte 1 pro Bojovníka nebo 2 pro Jízdu na Koni.");
                }
            }
        }
    }
}