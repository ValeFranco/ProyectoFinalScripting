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
      
       internal static void AumentarAltura()
       {

       }
    }
}
