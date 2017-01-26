using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            int sekuntti, sekunnit, minuutit, tunnit;

            Console.WriteLine("Anna sekunnit >");
            string line = Console.ReadLine();
            sekuntti = int.Parse(line);

            
            tunnit = sekuntti / 3600; //Seuraavaksi sekuntimäärä muutetaan tunneiksi, minuuteiksi ja sekunneiksi. Tunnit saadaan laskettua tasajakamalla sekuntimäärä 3600:lla.
            minuutit = (sekuntti % 3600) / 60; // Jakojäännöstä käyttämällä saadaan lasketuksi ne sekunnit, jotka eivät kuulu kokonaisiin tunteihin tai minuutteihin.
            sekunnit = (sekuntti % 3600) % 60;


            Console.WriteLine("Antamasi sekunttiaika voidaan ilmaista muodossa " + tunnit + " tunti " + minuutit + " minuutti " + sekunnit + " sekuntti.");

            Console.ReadLine();
        }
    }
}