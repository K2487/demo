using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            int pisteet;
            Console.Write("Anna pistemäärä ");
            string line = Console.ReadLine();
            pisteet = int.Parse(line);
            switch (pisteet)

            {
                case 0:
                case 1:
                    Console.WriteLine("Arvosana 0");
                    break;

                case 2:
                case 3:
                    Console.WriteLine("Arvosana 1");
                    break;

                case 4:
                case 5:
                    Console.WriteLine("Arvosana 2");
                    break;

                case 6:
                case 7:
                    Console.WriteLine("Arvosana 3");
                    break;

                case 8:
                case 9:
                    Console.WriteLine("Arvosana 4");
                    break;

                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Arvosana 5");
                    break;
            }
        }
    }
}
