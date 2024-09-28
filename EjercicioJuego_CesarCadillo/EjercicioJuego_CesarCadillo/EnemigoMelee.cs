using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJuego_CesarCadillo
{
    public class EnemigoMelee : Personaje
    {
        public EnemigoMelee(int vida, int daño) : base(vida, daño) { }

        public override void RecibirDaño(int daño)
        {
            Vida -= daño;
            Console.WriteLine($"Enemigo Melee recibe {daño} de daño. Vida restante: {Vida}");
        }

        public override int Atacar()
        {
            return Daño;
        }
    }
}
