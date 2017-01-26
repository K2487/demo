using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int satunnaisluku = random.Next(1, 100); 
            int vastaus;
            int yritykset = 0;

            do
            {
                yritykset++; // lisätään aina yrityksien jälkeen +1
                Console.Write("Arvaa satunnaisluku > ");
                string line = Console.ReadLine();
                vastaus = int.Parse(line);

                if (vastaus > satunnaisluku)
                {
                    Console.WriteLine("Luku on pienempi.");
                }

                if (vastaus < satunnaisluku)
                {
                    Console.WriteLine("Luku on korkeampi.");
                }

            } while (vastaus != satunnaisluku); // != ei sama kuin, looppaa niin kauan kunnes käyttäjä arvaa oikein

            Console.WriteLine("Oikein. Arvasit " + yritykset + " kertaa.");
            Console.ReadLine();
        }
    }
}