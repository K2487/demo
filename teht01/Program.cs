using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            // kysyy luvun
            int luku;
            Console.Write("Anna luku >");
            string line = Console.ReadLine(); 
            luku = int.Parse(line); 
            // numero
            switch (luku)
            {
                case 1:
                    Console.WriteLine("yksi");
                    break;

                case 2:
                    Console.WriteLine("kaksi");
                    break;

                case 3:
                    Console.WriteLine("kolme");
                    break;

                default:
                    Console.WriteLine("Joku muu luku");
                    break;
            }
        
            Console.ReadLine();
        }
    }
}