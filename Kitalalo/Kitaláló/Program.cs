using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaláló
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> szavak = new List<string>{"kutya", "macska", "léc", "billentyűzet", "zsebkendő", "padló", "fa", "rétes", "kicsi"};
            Random random = new Random();
            string rejtettSzo;
            string tipp;
            string valasz;
            int tippekSzama = 0;

            rejtettSzo = szavak[random.Next(szavak.Count)];
            while (true)
            {
                Console.Write("Tipp: ");
                tipp = Console.ReadLine();
                if (tipp == "stop")
                {
                    Console.WriteLine("Játék vége.");
                    Console.ReadKey();
                    break;
                }
                valasz = GeneraltValasz(rejtettSzo, tipp);
                Console.WriteLine("Válasz: " + valasz);
                tippekSzama++;
                if (valasz == rejtettSzo)
                {
                    Console.WriteLine($"Kitaláltad! Tippek száme: {tippekSzama}");
                    Console.ReadKey();
                    break;
                }
            }
        }

        static string GeneraltValasz(string rejtettSzo, string tipp)
        {
            string valasz = "";
            for (int i = 0; i < rejtettSzo.Length; i++)
            {
                if (rejtettSzo[i] == tipp[i])
                {
                    valasz += rejtettSzo[i];
                }
                else
                {
                    valasz += ".";
                }  
            }
            return valasz;
        }
    }
}
