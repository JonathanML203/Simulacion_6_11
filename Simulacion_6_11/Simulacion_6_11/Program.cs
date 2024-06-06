using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;

namespace Simulacion_6_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ingreso de datos
            Console.Write("\nIngrese la probabilidad de que X > x: ");
            double probabilidad1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la probabilidad de que X < y: ");
            double probabilidad2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la probabilidad de que X > 7: ");
            double probabilidad4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la probabilidad de que X < 12: ");
            double probabilidad3 = Convert.ToDouble(Console.ReadLine());


            double valorZ1 = Normal.InvCDF(0, 1, 1 - probabilidad1);
            double valorZ2 = Normal.InvCDF(0, 1, probabilidad2);
            double valorZ3 = Normal.InvCDF(0, 1, probabilidad3);
            double valorZ4 = Normal.InvCDF(0, 1, 1 - probabilidad4);
            double sigma = (12 - 7) / (valorZ3 - valorZ4);
            double MAprox = 12 - sigma * valorZ3;
            double x = MAprox + valorZ1 * sigma;
            double y = MAprox + valorZ2 * sigma;
            double valorZ5 = (8 - MAprox) / sigma;
            double valorZ6 = (10 - MAprox) / sigma;
            double proporcion = Normal.CDF(0, 1, valorZ6) - Normal.CDF(0, 1, valorZ5);



            Console.WriteLine("\n\na) Media aproximada: " + MAprox);
            Console.WriteLine("\n   Desviación estándar (sigma) aproximada: " + sigma);
            Console.WriteLine("\nb) Proporción de individuos entre 8 y 10 milímetros: " + proporcion);
            Console.WriteLine("\nc) Valor aproximado de x: " + x);
            Console.WriteLine("\n   Valor aproximado de y: " + y);
        }
    }
}
