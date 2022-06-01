using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura_u_danu
{
    internal class DataParser
    {
        List<double> listaTemperatura = new List<double>();
        public List<double> Parse(string sensorData)
        {
            List<string> data = new List<string>();
            data = sensorData.Split(';').ToList();
            listaTemperatura = data.Select(x=>double.Parse(x)).ToList();
            return listaTemperatura;
        }
        
    }
}
