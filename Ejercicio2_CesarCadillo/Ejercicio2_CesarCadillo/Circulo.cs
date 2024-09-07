using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_CesarCadillo
{
    public class Circulo : Figura
    {
        private float Radio;

        public Circulo(float radio)
        {
            Radio = radio;
        }

        public override float CalcularArea()
        {
            return (float)Math.PI * Radio * Radio;
        }
    }
}
