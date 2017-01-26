using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, luku3, sum, karv;
            Console.WriteLine("Anna 3 lukua >");
            string line1 = Console.ReadLine();
            luku1 = int.Parse(line1);
            string line2 = Console.ReadLine();
            luku2 = int.Parse(line2);
            string line3 = Console.ReadLine();
            luku3 = int.Parse(line3);

            sum = luku1 + luku2 + luku3; 
            karv = sum / 3; // summan avulla saadaan keskiarvo

            Console.WriteLine("Summa = " + sum);
            Console.WriteLine("Keskiarvo = " + karv);

            Console.ReadLine();
        }
    }
}