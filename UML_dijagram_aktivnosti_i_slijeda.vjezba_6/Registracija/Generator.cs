using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registracija
{
    internal class Generator
    {
        public string GenerirajEmail(string ime, string prezime)
        {
            return $"{ime.Substring(0, 1).ToLowerInvariant()}{prezime.Substring(0, 5).ToLowerInvariant()}@foi.hr";
        }
        public int GenerirajLozinku()
        {
            Random random = new Random();
            return random.Next(1000, 9999);
        }
    }
}
