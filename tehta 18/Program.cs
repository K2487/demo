using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna merkkijono > ");
            var original = Console.ReadLine();
            var reversed = new string(original.Reverse().ToArray());
            Console.WriteLine();


            Console.WriteLine(original);
            Console.WriteLine(reversed);
            if (original == reversed)
            { Console.WriteLine("Palidromi"); }
            else
            { Console.WriteLine("Ei palidromi"); }

            Console.ReadLine();
        }
    }
}