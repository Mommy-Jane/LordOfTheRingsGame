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
                combat firstgoblin = new combat();
                firstgoblin.ZacitSouboj(plr);

                Console.WriteLine("{0}: Po náročném boji jsem porazil goblina. Musím se vrátit do Valinoru a informovat o nebezpečí.", plr.name);

                // Pokračování příběhu elfa...
                Continue();
            }
        }
    }
}