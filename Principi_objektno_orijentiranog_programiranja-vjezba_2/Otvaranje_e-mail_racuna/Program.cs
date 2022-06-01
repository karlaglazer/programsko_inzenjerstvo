using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otvaranje_e_mail_računa
{
    internal class Program
    {
        static EmailServer server = new EmailServer();
        static void Main(string[] args)
        {
            Console.WriteLine("Otvaranje email korisnickog racuna: ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Unesite vase ime: ");
            string ime = Console.ReadLine();
            Console.WriteLine("Unesite vase prezime: ");
            string prezime = Console.ReadLine();
            Console.WriteLine("------------------------------------");
            KorisnickiRacun racun = server.KreirajKorisnickiRacun(ime, prezime);
            Console.WriteLine("Podaci za vas email korisnicki racun: ");
            Console.WriteLine($"Ime: {ime}");
            Console.WriteLine($"Prezime: {prezime}");
            Console.WriteLine($"Email: {racun.Email}");
            Console.WriteLine($"Skraceni email: {racun.SkraceniEmail}");
            Console.WriteLine($"Lozinka: {racun.Lozinka}");
            Console.ReadLine();
        }
    }
}
