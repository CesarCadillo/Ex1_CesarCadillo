using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJuego_CesarCadillo
{
    public class Jugador : Personaje
    {
        public Jugador(int vida, int daño) : base(vida, daño) { }

        public override void RecibirDaño(int daño)
        {
            Vida -= daño;
            Console.WriteLine($"Jugador recibe {daño} de daño. Vida restante: {Vida}");
        }

        public override int Atacar()
        {
            return Daño;
        }
    }
}
