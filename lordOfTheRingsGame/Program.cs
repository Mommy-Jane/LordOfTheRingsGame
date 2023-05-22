using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lordOfTheRingsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            player plr = new player();
            Console.Title = "Pán Prstenu: Bitva u Železného Pásu";
            /* Console.WriteLine("Jelikož nás tlačil čas, dokončili jsme jenom příběh pro elfy. Při výběru rasy tedy vyberte Elfy");
            plr.Continue(); */
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
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Vítejte ve světě Pána prstenů hry!\r\n\r\nDobrý den! Vítáme vás ve světě Pána prstenů, plném dobrodružství a nebezpečí. Před tím, než se ponoříte do této epické hry, potřebujeme znát vaše jméno a rozhodnutí ohledně rasy, za kterou budete hrát.");
            plr.Continue();
            Console.WriteLine("Jaké jméno si přejete pro svou postavu? A zvažujete, zda se připojíte k dobrodružství jako Člověk nebo jako Elf?\r\n\r\nProsím, zapište své jméno níže a poté vyberte jednu z následujících možností:");
            Console.WriteLine("1. Pokud si přejete hrát za statečného Člověka.");
            Console.WriteLine("2. Pokud se cítíte spřízněni s grácií a moudrostí Elfů.");

            Console.WriteLine();
            Console.WriteLine("V Napište své jméno a poté stiskněte Enter V");
            plr.name = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("V Napište svou volbu rasy (1 pro Člověka, 2 pro Elfa) a poté stiskněte Enter V");
            plr.Chooserace();

            if (plr.race == "Člověk")
            {
                Console.WriteLine();
                Console.WriteLine("V Vybral jste si rasu lidí, vyberte si třídu bojovníka (1 pro Bojovník, 2 pro Jízdu na Koni) a poté stiskněte Enter V");
                plr.Chooseclass();
                Console.WriteLine();
            }

            Console.WriteLine("Dobrá {0} {1}, pojďme společně vydat se na neuvěřitelné dobrodružství ve světě Středozemě!", plr.race, plr.name);
            plr.Continue();

            story pribeh = new story();
            pribeh.Start(plr);
        }
    }
}
