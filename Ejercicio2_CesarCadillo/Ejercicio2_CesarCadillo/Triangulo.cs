using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_CesarCadillo
{
    public class Triangulo : Figura
    {
        private float Base;
        private float Altura;

        public Triangulo(float baseTriangulo, float altura)
        {
            Base = baseTriangulo;
            Altura = altura;
        }

        public override float CalcularArea()
        {
            return (Base * Altura) / 2;
        }
    }
}
