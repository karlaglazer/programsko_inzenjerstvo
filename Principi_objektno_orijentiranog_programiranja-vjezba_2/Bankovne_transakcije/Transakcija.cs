﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankovne_transakcije
{
    internal class Transakcija
    {
        public Racun Platitelj { get; set; }
        public Racun Primatelj { get; set; }
        public double Iznos { get; set; }
        public Transakcija()
        {

        }

    }
}
