using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht09
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku0;
            int luku1;


            Console.WriteLine("Anna luku >");
            string line = Console.ReadLine();
            luku1 = int.Parse(line);
            luku0 = luku1;
            if (luku1 == 0)
            {
                Console.WriteLine("Lukujen summa on " + luku0);
            }
            while (luku1 != 0)
            {

                Console.WriteLine("Anna luku >");
                line = Console.ReadLine();
                luku1 = int.Parse(line);
                luku0 = luku1;
                if (luku1 == 0)
                {
                    Console.WriteLine("Lukujen summa on " + luku0);
                }
            }
        }
    }
}
