using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_CesarCadillo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Selecciona una figura para calcular el área:");
                Console.WriteLine("1. Rectángulo");
                Console.WriteLine("2. Cuadrado");
                Console.WriteLine("3. Círculo");
                Console.WriteLine("4. Triángulo");
                Console.Write("Opción: ");
                int opcion = int.Parse(Console.ReadLine());

                Figura figura = null;

                switch (opcion)
                {
                    case 1:
                        Console.Write("Introduce la base del rectángulo: ");
                        float baseRect = float.Parse(Console.ReadLine());
                        Console.Write("Introduce la altura del rectángulo: ");
                        float alturaRect = float.Parse(Console.ReadLine());
                        figura = new Rectangulo(baseRect, alturaRect);
                        break;
                    case 2:
                        Console.Write("Introduce el lado del cuadrado: ");
                        float lado = float.Parse(Console.ReadLine());
                        figura = new Cuadrado(lado);
                        break;
                    case 3:
                        Console.Write("Introduce el radio del círculo: ");
                        float radio = float.Parse(Console.ReadLine());
                        figura = new Circulo(radio);
                        break;
                    case 4:
                        Console.Write("Introduce la base del triángulo: ");
                        float baseTriangulo = float.Parse(Console.ReadLine());
                        Console.Write("Introduce la altura del triángulo: ");
                        float alturaTriangulo = float.Parse(Console.ReadLine());
                        figura = new Triangulo(baseTriangulo, alturaTriangulo);
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        continue;
                }

                Console.WriteLine($"El área de la figura seleccionada es: {figura.CalcularArea()}");

                Console.WriteLine("¿Deseas calcular otra área? (s/n): ");
                continuar = Console.ReadLine().ToLower() == "s";
            }
        }
    }
}
