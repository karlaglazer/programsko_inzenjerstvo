using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bodovi_na_vježbama
{
    internal class Student
    {
        public int Id { get; set; }
        public string Ime { get; set; }

        public double Bodovi { get; set; }
        public Student(int id, string ime, double bodovi)
        {
            Id = id;
            Ime = ime;
            Bodovi = bodovi;
        }
    }
}
