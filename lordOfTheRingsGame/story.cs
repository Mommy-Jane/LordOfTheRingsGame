using System;
using System.Diagnostics;

namespace lordOfTheRingsGame
{
    public class story
    {
        public void Continue() {
            Console.WriteLine("Stiskněte libovolnou klávesu . . .");
            Console.ReadKey();
            Console.Clear();
        }

        public void Start(player plr) { 
            if (plr.race == "Elf")
            {
                Console.WriteLine("Část: Příběh Elf");
                Console.WriteLine("Hlavní postava je Elf {0}, který se vydává na průzkum do temného lesa, který ohrožuje Valinor, město elfů.", plr.name);
                Console.WriteLine();

                Console.WriteLine("{0}: Přibližuji se k temnému lesu. Všechno kolem je pokryto hustým stínem. Ale já se nezaleknu. Pokračuji vpřed.", plr.name);
                Console.WriteLine();

                Console.WriteLine("{0}: Najednou z lesa vyskočí zrádný goblin a útočí na mě! Je čas se bránit!", plr.name);

                // Zde by byl kód pro bojový systém, kde hráč může interagovat s bojovými možnostmi (útok, obrana, kouzlo apod.)
                Continue();
                Console.WriteLine($"Sam: Vítej v našem souboji! Představím ti rychlé shrnutí toho, jak souboj funguje.\r\n\r\n{plr.name}: Skvěle! Rád bych věděl, jak se budu bránit před příšerou.\r\n\r\nSam: Jistě, mám to pro tebe. Každé kolo souboje se skládá z několika kroků. Nejprve máš možnost vybrat mezi dvěma akcemi: útokem nebo obranou.\r\n\r\n{plr.name}: Rozumím. A co se děje potom?\r\n\r\nSam: Poté, co vybereš svoji akci, příšera se také rozhodne, zda zaútočí na tebe nebo se bude bránit. Tyto rozhodnutí jsou založena na náhodě, takže není předem jasné, co se stane.\r\n\r\n{plr.name}: To zní napínavě! A co když se rozhodnu zaútočit?\r\n\r\nSam: Pokud se rozhodneš zaútočit, provedeš svůj útok a způsobíš příšerě určité množství poškození. Poté se příšera rozhodne, zda tě zaútočí zpět nebo se brání.\r\n\r\n{plr.name}: A když se rozhodnu bránit?\r\n\r\nSam: Pokud se rozhodneš bránit, zvýší se tvá obrana a sníží se šance, že tě příšera zasáhne. Poté se příšera rozhodne, zda se brání nebo zaútočí na tebe.\r\n\r\n{plr.name}: Chápu. Takže každé kolo je plné nejistoty a taktických rozhodnutí.\r\n\r\nSam: Přesně tak! Souboj je dynamický a závisí na tvojí strategii a štěstí. Cílem je sestřelit příšeru předtím, než ona sestřelí tebe.\r\n\r\n{plr.name}: Díky za vysvětlení! Už se nemůžu dočkat, až se chopím své zbraně a stanu se hrdinou!\r\n\r\nSam: Držím ti palce! Buď opatrný a bojuj statečně. Buď si jist, že ti budu stát po boku a podpořím tě v boji.\r\n\r\n{plr.name}: Díky, Sam. Jsem vděčný za tvou pomoc a podporu. Společně překonáme jakékoli překážky!\r\n\r\nSam: Tímto to začíná, {plr.name}. Připrav se na souboj a buď nejlepší verzí sebe sama!");
                combat combater = new combat();
                combater.ZacitSouboj(plr);

                Console.WriteLine("{0}: Po náročném boji jsem porazil goblina. Musím se vrátit do Valinoru a informovat o nebezpečí.", plr.name);
                Continue();
                // Hráč se vrací do Valinoru a hledá radu u moudrého staršího elfa.

                Console.WriteLine("[Vrací se do Valinoru a hledá radu u moudrého staršího elfa.]");
                Console.WriteLine();
                Console.WriteLine($"{plr.name}: Starší elfe, přišel jsem s důležitou zprávou. Porazil jsem goblina, ale nebezpečí se blíží k našim hranicím.");
                Console.WriteLine();
                Console.WriteLine("Starší elf: Dobrá práce, mladý elfe. Tvá odvaha a statečnost jsou nesmírně cenné. Musíme jednat rychle, abychom ochránili naše domovy.");
                Console.WriteLine();
                Console.WriteLine($"{plr.name}: Co bychom měli udělat, starší elfe?");
                Console.WriteLine();
                Console.WriteLine("Starší elf: Shromáždíme naše nejlepší bojovníky a připravíme se na obranu. Musíme posílit naše hranice a připravit strategii.");
                Console.WriteLine();
                Console.WriteLine($"{plr.name}: Jsem připraven bojovat a bránit Valinor. Svého nepřítele nepustím blíž!");
                Console.WriteLine();
                Console.WriteLine($"[{plr.name} se připojuje ke svým druhům v přípravě na obranu Valinoru.]");

                Continue();

                Console.WriteLine($"{plr.name}: Dny před bojem jsou napjaté. Každý elf se připravuje na nejtěžší bitvu, kterou jsme kdy čelili.");
                Console.WriteLine();
                Console.WriteLine($"{plr.name}: Shromáždili jsme naše nejlepší bojovníky a vytvořili strategii, jak odrazit temné síly.");
                Console.WriteLine();
                Console.WriteLine($"{plr.name}: Naše hranice jsou posílené a ochráněné mocnou magií, kterou jsme naučili.");
                Console.WriteLine();
                Console.WriteLine($"{plr.name}: Přichází den rozhodnutí. Z temných lesů se blíží armáda goblinů a zlých bytostí.");
                Console.WriteLine();
                Console.WriteLine($"{plr.name}: V bitvě zuří zuřivé souboje, meče se kříží a magie je vypouštěna do vzduchu.");
                Console.WriteLine();
                Console.WriteLine($"{plr.name}: Záře elfských mečů osvětluje noc a odhodlání v srdcích elfů je silné.");
                
                Continue();
                combater.ZacitSouboj(plr);
                combater.ZacitSouboj(plr);
                combater.ZacitSouboj(plr);
                Continue();

                Console.WriteLine($"{plr.name}: Po několika dlouhých hodinách boje se zdá, že temné síly ustupují.");
                Console.WriteLine();
                Console.WriteLine($"{plr.name}: Valinor zůstává nedobytný, díky statečnosti a jednotě našeho lidu.");
                Console.WriteLine();
                Console.WriteLine($"{plr.name}: S hrdostí můžeme říct, že jsme ochránili naše domovy a zachovali mír.");
                Console.WriteLine();
                Console.WriteLine($"[{plr.name} slaví vítězství a odpočívá po náročném boji.]");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Děkujeme, že jste se zúčastnili dobrodružství elfa!");
                Console.WriteLine("Doufáme, že jste si ho užili. Přijďte znovu!");
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}