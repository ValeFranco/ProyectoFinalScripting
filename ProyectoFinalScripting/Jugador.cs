using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoFinalScripting
{
    public class Jugador
    {
        internal uint poder;
        string nombre;
        internal byte vidas;
       


        public Jugador(uint poder, string nombre)
        {
            Poder = poder;
            Nombre = nombre;
            vidas = 3;
            

        }

        public uint Poder {
            get => poder;

            set
            {
                if (value > 0)
                {
                    poder = value;
                }

                else
                    throw new Exception("el poder inicial del usuario no puede ser cero");
            }
        }
       

        public string Nombre
        {
            get => nombre; set
            {

                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("el nombre no puede tener espacios en blanco  ");
                }
                else
                {
                    nombre = value;
                }

            }
        }

       
    }

    

}
