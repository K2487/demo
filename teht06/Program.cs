using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            int matka;
            double litra, hinta;
            Console.WriteLine("Anna matka > ");
            string line = Console.ReadLine();
            matka = int.Parse(line);

            litra = (7.02 / 100) * matka; //jaetaan litrat (7.02) kilometrimäärällä (100) ja kerrotaan annetulla matkalla 
            hinta = litra * 1.595; //hinta selviää litra kertaa bensan hinta (1.595)

            Console.WriteLine("Bensaa kuluu " + litra + " litraa, kustannus " + hinta + " euroa.");
        }
    }
}
