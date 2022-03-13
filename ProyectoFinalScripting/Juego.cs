using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalScripting
{
    public class Juego
    {
        public List<Torre> l_torres = new List<Torre>();

        public Juego()
        {
    
        }

        /*
        public bool Atacar(TorreJugador t_jugador, Atacable target, TorreEnemigo torre)
        {
            bool victoria = false;

            if (torre.l_atacable.IndexOf(target) == -1)
            {
                throw new Exception("el enemigo no está en esta torre");

            }

            if (target.esObstaculo == true)
            {
                t_jugador.jugador.poder += target.poder;
                victoria = true;
                return victoria;
            }

            if (target.esObstaculo == false)
            {
                if (target.poder > t_jugador.jugador.poder)
                {
                    victoria = false;
                    t_jugador.jugador.vidas--;
                    return victoria;

                }

                if (target.poder == t_jugador.jugador.poder)
                {
                    victoria = false;
                    t_jugador.jugador.vidas--;
                    return victoria;

                }


                else if (target.poder < t_jugador.jugador.poder)
                {

                    victoria = true;
                    t_jugador.jugador.poder += target.poder;
                    torre.ReducirAltura(target);
                    t_jugador.AumentarAltura();



                    if (torre.Altura == 0 || torre.l_atacable.Count == 0)
                    {
                        DestruirTorre(torre);
                    }


                    return victoria;

                }

            }

            return victoria;


        }
        */
        
    }

}
