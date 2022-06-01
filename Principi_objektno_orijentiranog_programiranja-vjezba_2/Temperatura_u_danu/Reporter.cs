using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura_u_danu
{
    internal class Reporter
    {
        static Sensor sensor = new Sensor();
        static DataParser dataParser = new DataParser();
        private double GetMinimalTemperature(List<double> lista)
        {
            return lista.Min();
        }
        private double GetMaximalTemperature(List<double> lista)
        {
            return lista.Max();
        }
        private double GetAverageTemperature(List<double> lista)
        {
            double zbroj = 0;
            foreach(double p in lista)
            {
                zbroj += p;
            }
            double prosjecna = zbroj / (double)lista.Count;
            return prosjecna;
        }
        public string GenerateReport()
        {
            List<double> lista = new List<double>();
            string podaci = sensor.GetData();
            lista = dataParser.Parse(podaci);
            return $"Prosjecna temperatura je {GetAverageTemperature(lista)} C, minimalna temperatura je {GetMinimalTemperature(lista)} C, maksimalna temperatura je {GetMaximalTemperature(lista)} C";
        }
    }
}
