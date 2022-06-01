using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godišnja_doba
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Upišite proizvoljan datum u formatu 'dd mmmm' (npr. 20 siječanj):");
            string upisaniDatum = Console.ReadLine();
            string[] polje = upisaniDatum.Split(' ');
            int dan = int.Parse(polje[0]); 
            switch (polje[1])
            {
                case "sijecanj":
                    Console.WriteLine($"Dan {dan}. {polje[1]} pripada godišnjem dobu zima.");
                    break;
                case "veljaca":
                    Console.WriteLine($"Dan {dan}. {polje[1]} pripada godišnjem dobu zima.");
                    break;
                case "ozujak":
                    if (dan < 21)
                    {
                        Console.WriteLine($"Dan {dan}. {polje[1]} pripada godišnjem dobu zima."); 
                    }
                    else
                    {
                        Console.WriteLine($"Dan {dan}. {polje[1]} pripada godišnjem dobu proljeće.");
                    }
                    break;
                case "travanj":
                    Console.WriteLine($"Dan {dan}. {polje[1]} pripada godišnjem dobu proljeće.");
                    break;
                case "svibanj":
                    Console.WriteLine($"Dan {dan}. {polje[1]} pripada godišnjem dobu proljeće.");
                    break;
                case "lipanj":
                    if (dan < 21)
                    {
                        Console.WriteLine($"Dan {dan}. {polje[1]} pripada godišnjem dobu proljeće.");
                    }
                    else
                    {
                        Console.WriteLine($"Dan {dan}. {polje[1]} pripada godišnjem dobu ljeto.");
                    }
                    break;
                case "srpanj":
                    Console.WriteLine($"Dan {dan}. {polje[1]} pripada godišnjem dobu ljeto.");
                    break;
                case "kolovoz":
                    Console.WriteLine($"Dan {dan}. {polje[1]} pripada godišnjem dobu ljeto.");
                    break;
                case "rujan":
                    if (dan < 23)
                    {
                        Console.WriteLine($"Dan {dan}. {polje[1]} pripada godišnjem dobu ljeto.");
                    }
                    else
                    {
                        Console.WriteLine($"Dan {dan}. {polje[1]} pripada godišnjem dobu jesen.");
                    }
                    break;
                case "listopad":
                    Console.WriteLine($"Dan {dan}. {polje[1]} pripada godišnjem dobu jesen.");
                    break;
                case "studeni":
                    Console.WriteLine($"Dan {dan}. {polje[1]} pripada godišnjem dobu jesen.");
                    break;
                case "prosinac":
                    if (dan < 21)
                    {
                        Console.WriteLine($"Dan {dan}. {polje[1]} pripada godišnjem dobu jesen.");
                    }
                    else
                    {
                        Console.WriteLine($"Dan {dan}. {polje[1]} pripada godišnjem dobu zima.");
                    }
                    break;
            }
            
            Console.ReadLine();
        }
    }
}
