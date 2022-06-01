using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bodovi_na_vježbama
{
    internal class Evidencija 
    {
        protected List<Student> studenti;
        protected List<Vjezba> vjezba;
        public Evidencija()
        {
            studenti = new List<Student>();
            vjezba = new List<Vjezba>();
        }

        public void DodajStudenta()
        {
            Console.WriteLine("Unesite ID studenta: ");
            int studentId = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite Ime i Prezime studenta: ");
            string imePrezime = Console.ReadLine();
            studenti.Add(new Student(studentId, imePrezime, 0));
        }

        public void NovaVjezba()
        {
            Console.WriteLine("Unesite broj vjezbe: ");
            int broj = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite naziv vjezbe: ");
            string naziv = Console.ReadLine(); 
            vjezba.Add(new Vjezba(broj, naziv));
            char izbor = 'd';
            while (izbor != 'n')
            {
                Console.WriteLine("Unesite ID studenta: ");
                int id = int.Parse(Console.ReadLine());
                foreach(Student s in studenti)
                {
                    if (id == s.Id)
                    {
                        Console.WriteLine("Unesite bodove studenta: ");
                        double bodovi = double.Parse(Console.ReadLine());
                        s.Bodovi += bodovi;
                    }
                }
                Console.WriteLine("Nastavi (d/n)");
                izbor = char.Parse(Console.ReadLine());
            }
        }
        public void Ispis()
        {
            foreach(Student s in studenti)
            {
                Console.WriteLine($"Ime: {s.Ime} bodovi: {s.Bodovi}");
            }
        }
    }
}
