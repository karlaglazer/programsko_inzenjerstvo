using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino1
{
    internal class Projekcija
    {
        public DateTime Vrijeme { get; set; }
        public Dvorana BrojDvorane { get; set; }
        public Film PrikazFilma { get; set; }
        public bool Premijera { get; set; }
    }
}
