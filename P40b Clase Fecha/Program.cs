using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P40b_Clase_Fecha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fecha f1 = new Fecha();
            Console.WriteLine(f1.EsBisiesto);


            Console.WriteLine("Pulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}
