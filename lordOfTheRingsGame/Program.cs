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
            plr.name = "Ahoj";
            Console.WriteLine(plr.name);
        }
    }
}
