using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_CesarCadillo
{
    public  class Cuadrado : Figura
    {
        private float Lado;

        public Cuadrado(float lado)
        {
            Lado = lado;
        }

        public override float CalcularArea()
        {
            return Lado * Lado;
        }
    }
}
