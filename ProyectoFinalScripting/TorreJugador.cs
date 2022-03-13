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
        internal List<object> l_jugador;

        public TorreJugador(uint altura, Jugador jugador) : base(altura)
        {
            this.Altura = altura;
            this.jugador = jugador;
            l_jugador = new List<object>((int)altura);
            l_jugador.Add(jugador);
        }
         public Jugador Jugador { get => jugador; set => jugador = value; }
        internal  void AumentarAltura()
        {
            List<object> newlist = new List<object>(((int)Altura) + 1);
            newlist.Add(jugador);

            l_jugador = newlist;
            Altura++;
        }

        internal bool Atacar(Atacable target, TorreEnemigo torre)
        {
            bool victoria = false;

            if(torre.l_atacable.IndexOf(target)==-1)
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
                    torre.ReducirAltura(target);
                    AumentarAltura();

                    if (torre.altura == 0 || torre.l_atacable.Count == 0)
                    {
                        torre = null;
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
                l_jugador.Add(objeto);
            }
            else if (objeto is Atacable)
            {
                Atacable test = objeto as Atacable;

                if (!test.esObstaculo)
                {
                    l_jugador.Add(objeto);
                }

                else
                    throw new Exception("no se pueden añadir enemigos a la torre");
            }
        }

    
    }
}
