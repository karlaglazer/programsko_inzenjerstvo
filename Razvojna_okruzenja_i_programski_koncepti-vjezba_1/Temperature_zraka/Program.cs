using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_zraka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string glavni = "13,2|13,6|-|14,8|15,1|-|14,2|13,7";
            string rezervni = "286,45|286,85|287,25|288,05|288,35|287,95|287,45|286,95";
            string[] glavniPolje = glavni.Split('|');
            string[] rezervniPolje = rezervni.Split('|');
            int brojac = 0;
            double zbrojTemperatura = 0;
            double temperatura;
            foreach(string s in glavniPolje)
            {
                if (s != "-")
                {
                    
                    
                    temperatura = double.Parse(s.Replace(',','.'));
                    zbrojTemperatura+=double.Parse(s.Replace(',', '.'));
                }
                else
                {
                    
                    temperatura = double.Parse(rezervniPolje[brojac].Replace(',','.')) - 273.15;
                    zbrojTemperatura += double.Parse(rezervniPolje[brojac].Replace(',','.')) - 273.15;
                }
                brojac++;
                Console.WriteLine($"{temperatura} °C");
            }
            double prosjecnaTemperatura = Math.Round(zbrojTemperatura / brojac,1);
            Console.WriteLine($"Prosječna izmjerena temperatura je {prosjecnaTemperatura}!");
            
            Console.ReadLine();
        }
    }
}
