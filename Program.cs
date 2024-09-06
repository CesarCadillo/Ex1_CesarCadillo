using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_CesarCadillo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();

            while (true)
            {
                Console.WriteLine("1. Agregar persona\n2. Convertir persona en alumno\n3. Editar alumno\n4. Mostrar información\n5. Salir");
                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Edad: ");
                    int edad = int.Parse(Console.ReadLine());

                    personas.Add(new Persona(nombre, edad));
                }
                else if (opcion == "2")
                {
                    Console.Write("Nombre de la persona: ");
                    string nombre = Console.ReadLine();
                    Persona persona = personas.Find(p => p.Nombre == nombre);

                    if (persona != null && !(persona is Alumno))
                    {
                        Console.Write("Carrera: ");
                        string carrera = Console.ReadLine();
                        Console.Write("Ciclo: ");
                        int ciclo = int.Parse(Console.ReadLine());

                        Alumno alumno = new Alumno(persona.Nombre, persona.Edad, carrera, ciclo);
                        personas[personas.IndexOf(persona)] = alumno;
                    }
                    else
                    {
                        Console.WriteLine("Persona no encontrada o ya es un alumno.");
                    }
                }
                else if (opcion == "3")
                {
                    Console.Write("Nombre del alumno: ");
                    string nombre = Console.ReadLine();
                    Alumno alumno = personas.Find(p => p.Nombre == nombre) as Alumno;

                    if (alumno != null)
                    {
                        Console.Write("Nuevo ciclo: ");
                        int nuevoCiclo = int.Parse(Console.ReadLine());
                        alumno.CambiarCiclo(nuevoCiclo);
                    }
                    else
                    {
                        Console.WriteLine("Alumno no encontrado.");
                    }
                }
                else if (opcion == "4")
                {
                    foreach (var persona in personas)
                    {
                        persona.MostrarInformacion();
                        Console.WriteLine();
                    }
                }
                else if (opcion == "5")
                {
                    break;
                }
            }
        }
    }
}
    

