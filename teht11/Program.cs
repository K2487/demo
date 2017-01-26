using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht11
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            Console.WriteLine("anna luku >");
            string line = Console.ReadLine();
            luku = int.Parse(line);
            for (int i = 0; i < luku; i++) Console.Write("*");
        }
    }
}