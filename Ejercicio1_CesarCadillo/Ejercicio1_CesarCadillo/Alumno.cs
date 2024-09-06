using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_CesarCadillo
{
    public class Alumno : Persona
    {
        public string Carrera { get; set; }
        public int CicloCursante { get; set; }

        public Alumno(string nombre, int edad, string carrera, int cicloCursante)
            : base(nombre, edad)
        {
            Carrera = carrera;
            CicloCursante = cicloCursante;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Carrera: {Carrera}, Ciclo: {CicloCursante}");
        }

        public void CambiarCiclo(int nuevoCiclo)
        {
            CicloCursante = nuevoCiclo;
            Console.WriteLine($"El ciclo de {Nombre} ha sido actualizado a: {CicloCursante}");
        }

        public void AsignarCarreraYCiclo(string carrera, int cicloCursante)
        {
            Carrera = carrera;
            CicloCursante = cicloCursante;
            Console.WriteLine($"Carrera y ciclo asignados a {Nombre}: Carrera - {Carrera}, Ciclo - {CicloCursante}");
        }
    }
}