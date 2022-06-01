using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura_u_danu
{
    internal class Program
    {
        static Reporter report = new Reporter();
        static void Main(string[] args)
        {
            Console.WriteLine("TEMPERATURE REPORT");
            Console.WriteLine("---------------------");
            Console.WriteLine(report.GenerateReport());
            Console.ReadLine();
        }
    }
}
