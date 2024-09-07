using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_CesarCadillo
{
    public class Rectangulo : Figura
    {
        private float Base;
        private float Altura;

        public Rectangulo(float baseRect, float altura)
        {
            Base = baseRect;
            Altura = altura;
        }

        public override float CalcularArea()
        {
            return Base * Altura;
        }
    }
}
