using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProyectoFinalScripting.Juego;

namespace ProyectoFinalScripting
{
    public class TorreJugador : Torre
    {
         Jugador jugador;
        internal List<object> listaJugador;

        public TorreJugador(uint altura, Jugador jugador) : base(altura)
        {
            this.Altura = altura;
            this.jugador = jugador;
            listaJugador = new List<object>((int)altura);
            listaJugador.Add(jugador);
        }
         public Jugador Jugador { get => jugador; set => jugador = value; }
        internal  void AumentarAltura()
        {
            List<object> listaNueva = new List<object>(((int)Altura) + 1);
            listaNueva.Add(jugador);

            listaJugador = listaNueva;
            Altura++;
        }

        internal bool Atacar(Atacable target, TorreEnemigo torreEnemigo)
        {
            bool victoria = false;

            if(torreEnemigo.listaAtacable.IndexOf(target)==-1)
            {
                throw new Exception("el enemigo no está en esta torre");  
            }
            if (target.esObstaculo == true)
            {
                jugador.poder += target.poder;
                victoria = true;
                return victoria;
            }
            if (target.esObstaculo == false)
            {
                if (target.poder > jugador.poder)
                {
                    victoria = false;
                    jugador.vidas--;
                    return victoria;
                }
                if (target.poder == jugador.poder)
                {
                    victoria = false;
                    jugador.vidas--;
                    return victoria;
                }
                else if (target.poder < jugador.poder)
                {
                    victoria = true;
                    jugador.poder += target.poder;
                    torreEnemigo.ReducirAltura(target);
                    AumentarAltura();

                    if (torreEnemigo.altura == 0 || torreEnemigo.listaAtacable.Count == 0)
                    {
                        torreEnemigo = null;
                    }
                    return victoria;
                }
            }
            return victoria;
        }
        public void AñadirATorre(object objeto)
        { 
            if (objeto is Jugador)
            {
                listaJugador.Add(objeto);
            }
            else if (objeto is Atacable)
            {
                Atacable test = objeto as Atacable;

                if (!test.esObstaculo)
                {
                    listaJugador.Add(objeto);
                }
                else
                    throw new Exception("no se pueden añadir enemigos a la torre");
            }
        }
    }
}
