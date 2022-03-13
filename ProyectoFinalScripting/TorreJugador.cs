using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalScripting
{
    class TorreJugador : Torre
    {
        Jugador jugador;

        public TorreJugador(uint altura, Jugador jugador) : base(altura)
        {
            this.Altura = altura;
            this.jugador = jugador;
        }
        internal Jugador Jugador { get => jugador; set => jugador = value; }
        internal static TorreJugador CrearTorreJugador(TorreJugador result)
        {

            Random random = new Random();
            uint altura = (uint)(random.Next(1, 5));

            uint poderJugador = (uint)(random.Next(1, 5));
            Jugador jugador = new Jugador(poderJugador, "Sebastian");

            result.Altura = altura;
            result.Jugador = jugador;
            return result;
        }
        internal static void AumentarAltura()
       {

       }
    }
}
