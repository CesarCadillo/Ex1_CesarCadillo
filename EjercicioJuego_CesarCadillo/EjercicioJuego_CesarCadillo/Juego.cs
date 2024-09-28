using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJuego_CesarCadillo
{
    public class Juego
    {
        private Jugador jugador;
        private List<Personaje> enemigos;

        public Juego()
        {
            InicializarJuego();
        }

        private void InicializarJuego()
        {
            Console.WriteLine("Crea tu jugador (Vida y Daño no pueden superar 100)");
            Console.Write("Vida: ");
            int vida = int.Parse(Console.ReadLine());
            Console.Write("Daño: ");
            int daño = int.Parse(Console.ReadLine());

            if (vida > 100 || daño > 100)
            {
                Console.WriteLine("Valores no válidos. Reiniciando...");
                InicializarJuego();
                return;
            }

            jugador = new Jugador(vida, daño);
            enemigos = new List<Personaje>
                {
                    new EnemigoMelee(50, 10),
                    new EnemigoRango(40, 15, 3),
                    new EnemigoMelee(60, 12)
                };
        }

        public void Iniciar()
        {
            while (jugador.EstaVivo() && enemigos.Count > 0)
            {
                Console.WriteLine("\nTurno del jugador:");
                AtacarEnemigo();

                if (enemigos.Count == 0)
                {
                    Console.WriteLine("¡Victoria! Todos los enemigos han sido derrotados.");
                    Console.ReadLine();
                    break;
                }

                Console.WriteLine("\nTurno del enemigo:");
                AtacarJugador();
            }

            if (!jugador.EstaVivo())
            {
                Console.WriteLine("Has sido derrotado.");
                Console.ReadLine();
                return;
            }
        }

        private void AtacarEnemigo()
        {
            Console.WriteLine("Selecciona un enemigo para atacar:");
            for (int i = 0; i < enemigos.Count; i++)
            {
                var tipoEnemigo = enemigos[i] is EnemigoMelee ? "Melee" : "Rango";
                Console.WriteLine($"{i + 1}. Enemigo {tipoEnemigo} (Vida: {enemigos[i].Vida})");
            }

            int seleccion = int.Parse(Console.ReadLine()) - 1;
            if (seleccion >= 0 && seleccion < enemigos.Count)
            {
                var enemigo = enemigos[seleccion];
                if (!enemigo.EstaVivo())
                {
                    Console.WriteLine("Este enemigo ya está muerto.");
                }
                else
                {
                    enemigo.RecibirDaño(jugador.Atacar());
                    if (!enemigo.EstaVivo())
                    {
                        Console.WriteLine("Enemigo derrotado.");
                        enemigos.RemoveAt(seleccion);
                    }
                }
            }
        }

        private void AtacarJugador()
        {
            if (enemigos.Count > 0)
            {
                var enemigo = enemigos[0];
                if (enemigo.EstaVivo())
                {
                    jugador.RecibirDaño(enemigo.Atacar());
                }
            }
        }
    }
}
