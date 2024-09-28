using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJuego_CesarCadillo
{
    public abstract class Personaje
    {
        public int Vida { get; protected set; }
        public int Daño { get; protected set; }

        public Personaje(int vida, int daño)
        {
            Vida = vida;
            Daño = daño;
        }

        public abstract void RecibirDaño(int daño);
        public abstract int Atacar();
        public bool EstaVivo() => Vida > 0;
    }
}
