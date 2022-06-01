using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvenstvo
{
    internal class Prvenstvo
    {
        static Utakmica utakmica = new Utakmica();
        public List<Reprezentacija> reprezentacija = new List<Reprezentacija>();
        public List<Utakmica> Utakmica = new List<Utakmica>();
        public Prvenstvo()
        {

        }
        public void GenerirajTablicuRezultata()
        {
            foreach (Utakmica u in Utakmica)
            {
                utakmica.GenerirajIspis(u);
            }
        }
        public int Odredi_OU(Reprezentacija reprezentacija)
        {
            int brojac = 0;
            foreach (Utakmica u in Utakmica)
            {
                if (u.Domacin == reprezentacija || u.Gost == reprezentacija)
                {
                    brojac++;
                }
            }
            return brojac;
        }
        public int Odredi_POB(Reprezentacija reprezentacija)
        {
            int pobjeda = 0;
            foreach (Utakmica u in Utakmica)
            {
                if (u.Domacin == reprezentacija)
                {
                    if (u.BrojZgoditakaDomacin > u.BrojZgoditakaGost)
                    {
                        pobjeda++;
                    }
                }
                else if (u.Gost == reprezentacija)
                {
                    if (u.BrojZgoditakaGost > u.BrojZgoditakaDomacin)
                    {
                        pobjeda++;
                    }
                }
            }
            return pobjeda;
        }
        public int Odredi_NER(Reprezentacija reprezentacija)
        {
            int ner = 0;
            foreach (Utakmica u in Utakmica)
            {
                if (u.Domacin == reprezentacija || u.Gost == reprezentacija)
                {
                    if (u.BrojZgoditakaDomacin == u.BrojZgoditakaGost)
                    {
                        ner++;
                    }
                }
            }
            return ner;
        }
        public int Odredi_IZG(Reprezentacija reprezentacija)
        {
            int izgubljeno = 0;
            foreach (Utakmica u in Utakmica)
            {
                if (u.Domacin == reprezentacija)
                {
                    if (u.BrojZgoditakaDomacin < u.BrojZgoditakaGost)
                    {
                        izgubljeno++;
                    }
                }
                else if (u.Gost == reprezentacija)
                {
                    if (u.BrojZgoditakaGost < u.BrojZgoditakaDomacin)
                    {
                        izgubljeno++;
                    }
                }
            }
            return izgubljeno;
        }
        public int Odredi_POZ(Reprezentacija reprezentacija)
        {
            int golovi = 0;
            foreach (Utakmica u in Utakmica)
            {
                if (u.Domacin == reprezentacija)
                {
                    golovi += u.BrojZgoditakaDomacin;
                }
                else if (u.Gost == reprezentacija)
                {
                    golovi += u.BrojZgoditakaGost;
                }
            }
            return golovi;
        }
        public int Odredi_PRZ(Reprezentacija reprezentacija)
        {
            int golovi = 0;
            foreach (Utakmica u in Utakmica)
            {
                if (u.Domacin == reprezentacija)
                {
                    golovi += u.BrojZgoditakaGost;
                }
                else if (u.Gost == reprezentacija)
                {
                    golovi += u.BrojZgoditakaDomacin;
                }
            }
            return golovi;
        }
        public int Odredi_RAZ(Reprezentacija reprezentacija)
        {
            int razlika = Odredi_POZ(reprezentacija) - Odredi_PRZ(reprezentacija);
            return razlika;
        }
        public int Odredi_BOD(Reprezentacija reprezentacija)
        {
            int bodovi = Odredi_POB(reprezentacija) * 3;
            bodovi += Odredi_NER(reprezentacija);
            return bodovi;
        }
        public void GenerirajBodovnuLjestvicu()
        {
            Console.WriteLine("BODOVNA LJESTVICA");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("REP  OU  POB  NER  IZG  POZ  PRZ  RUZ  BOD");
            Console.WriteLine("------------------------------------------");
            foreach (Reprezentacija r in reprezentacija)
            {
                Console.WriteLine($"{r.Oznaka}   {Odredi_OU(r)}     {Odredi_POB(r)}     {Odredi_NER(r)}   {Odredi_IZG(r)}    {Odredi_POZ(r)}    {Odredi_PRZ(r)}    {Odredi_RAZ(r)}    {Odredi_BOD(r)}");
            }
        }
        public void UnesiReprezentaciju(string oznaka, string naziv)
        {
            reprezentacija.Add(new Reprezentacija(oznaka, naziv));
        }
        public void UnesiUtakmicu(string oznakaD, int goloviD, string oznakaG, int goloviG)
        {
            Reprezentacija repD = null;
            Reprezentacija repG = null;
            foreach(Reprezentacija r in reprezentacija)
            {
                if(r.Oznaka == oznakaD)
                {
                    repD = r;
                }
                if (r.Oznaka == oznakaG)
                {
                    repG = r;
                }
            }
            Utakmica.Add(new Utakmica(repD, repG, goloviD, goloviG));
        }
    
    }
}
