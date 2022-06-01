using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konverzija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite iznos u KUNAMA (cijeli broj) koji želite promijeniti (u tekstualnom obliku):");
            string tekstualniOblik = Console.ReadLine();
            string[] poljeTekst = tekstualniOblik.Split(' ');
            Console.WriteLine("Unesite tečaj EUR-a (u brojčanom decimalnom obliku: ");
            float tecaj = float.Parse(Console.ReadLine());
            int[] poljeBroj= new int[poljeTekst.Length];
            int indeks = 0;
            foreach (string i in poljeTekst)
            {
                switch (i)
                {
                    case "jedan":
                        poljeBroj[indeks] = 1;
                        break;
                    case "dva":
                        poljeBroj[indeks] = 2;
                        break;
                    case "tri":
                        poljeBroj[indeks] = 3;
                        break;
                    case "cetiri":
                        poljeBroj[indeks] = 4;
                        break;
                    case "pet":
                        poljeBroj[indeks] = 5;
                        break;
                    case "sest":
                        poljeBroj[indeks] = 6;
                        break;
                    case "sedam":
                        poljeBroj[indeks] = 7;
                        break;
                    case "osam":
                        poljeBroj[indeks] = 8;
                        break;
                    case "devet":
                        poljeBroj[indeks] = 9;
                        break;
                    case "nula":
                        poljeBroj[indeks] = 0;
                        break;
                }
                indeks++;
            }
            string kune =string.Concat(poljeBroj);
            float rezultat = float.Parse(kune) / tecaj;
            Console.WriteLine($"{kune} KN po tečaju {tecaj} iznosi {rezultat} EUR.");
            Console.ReadLine();
        }
    }
}
