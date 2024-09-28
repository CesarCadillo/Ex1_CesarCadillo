using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJuego_CesarCadillo
{
    public class EnemigoRango : Personaje
    {
        private int balas;

        public EnemigoRango(int vida, int daño, int balasIniciales) : base(vida, daño)
        {
            balas = balasIniciales;
        }

        public override void RecibirDaño(int daño)
        {
            Vida -= daño;
            Console.WriteLine($"Enemigo Rango recibe {daño} de daño. Vida restante: {Vida}");
        }

        public override int Atacar()
        {
            if (balas > 0)
            {
                balas--;
                return Daño;
            }
            else
            {
                Console.WriteLine("El enemigo de rango se quedó sin balas.");
                return 0;
            }
        }
    }
}
