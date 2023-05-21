using System;

namespace lordOfTheRingsGame
{
    public class combat
    {
        private Random random = new Random();

        public void ZacitSouboj(player hrac)
        {
            Console.WriteLine("Začíná souboj!");

            int zivotyPrisery = 100;

            while (hrac.GetHealth() > 0 && zivotyPrisery > 0)
            {
                Console.WriteLine("Vyberte akci:");
                Console.WriteLine("1. Útok");
                Console.WriteLine("2. Obrana");

                string volba = Console.ReadLine();

                Console.Clear(); // Vymazání textu v konzoli

                if (volba == "1")
                {
                    // Hráč provede útok
                    int utokHrace = random.Next(10, 21); // Útok hráče: náhodné číslo od 10 do 20

                    // Rozhodnutí příšery
                    bool priseraUtoci = random.Next(2) == 0;

                    if (priseraUtoci)
                    {
                        int utokPrisery = random.Next(10, 21); // Útok příšery: náhodné číslo od 10 do 20

                        int poskozeniPrisery = utokPrisery - utokHrace;
                        if (poskozeniPrisery > 0)
                        {
                            hrac.Damage(poskozeniPrisery);
                            Console.WriteLine($"Příšera zasáhla {hrac.name} a způsobila mu {poskozeniPrisery} bodů poškození.");
                        }
                        else
                        {
                            Console.WriteLine($"Příšera zasáhla {hrac.name}, ale jeho útok byl příliš silný. Nezpůsobila žádné poškození.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Příšera se brání proti útoku {hrac.name}.");
                    }

                    zivotyPrisery -= utokHrace;
                    Console.WriteLine($"{hrac.name} zasáhl příšeru a způsobil jí {utokHrace} bodů poškození.");
                }
                else if (volba == "2")
                {
                    // Hráč se brání
                    int obranaHrace = random.Next(5, 16); // Obrana hráče: náhodné číslo od 5 do 15

                    // Rozhodnutí příšery
                    bool priseraUtoci = random.Next(2) == 0;

                    if (priseraUtoci)
                    {
                        int utokPrisery = random.Next(10, 21); // Útok příšery: náhodné číslo od 10 do 20

                        int poskozeniPrisery = utokPrisery - obranaHrace;
                        if (poskozeniPrisery > 0)
                        {
                            hrac.Damage(poskozeniPrisery);
                            Console.WriteLine($"Příšera zasáhla {hrac.name} a způsobila mu {poskozeniPrisery} bodů poškození.");
                        }
                        else
                        {
                            Console.WriteLine($"Příšera zasáhla {hrac.name}, ale jeho obrana byla dostatečná. Nezpůsobila žádné poškození.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Příšera se brání proti obraně {hrac.name}.");
                    }
                }
                else
                {
                    Console.WriteLine("Neplatná volba. Zvolte prosím číslo 1 nebo 2.");
                    continue;
                }

                Console.WriteLine($"Zbývající zdraví hráče: {hrac.GetHealth()}");
                Console.WriteLine($"Zbývající zdraví příšery: {zivotyPrisery}");
                Console.WriteLine();
            }

            if (hrac.GetHealth() <= 0)
            {
                Console.WriteLine($"Souboj skončil! {hrac.name} byl poražen.");
            }
            else
            {
                Console.WriteLine($"Souboj skončil! {hrac.name} zvítězil nad příšerou.");
            }
        }
    }
}