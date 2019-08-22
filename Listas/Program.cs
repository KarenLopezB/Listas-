using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colores =
                new List<string>();
            colores.Add("rojo");
            colores.Add("verde");
            colores.Add("naranja");
            colores.Add("amarillo");
            colores.Add("azul");

            colores.RemoveAt(1); //Cuando removemos un elemento, los indices enumerados se recorren
            colores.Remove("amarillo");

            Console.WriteLine("Número de elementos: " +
                colores.Count);

            int indiceColor = 1;

            foreach (string color in colores)
            {
                Console.WriteLine(
                    "Elemento " + indiceColor.ToString() + 
                    ": " + color);
                indiceColor++;
            }

            // Console.WriteLine("Elemento 1: " +
            //     colores[0]);
            // Console.WriteLine("Elemento 2: " +
            //     colores[1]);
            // Console.WriteLine("Elemento 3: " +
            //     colores[2]);
            // Console.WriteLine("Elemento 4: " +
            //     colores[3]);

            Console.Read();
        }
    }
}
