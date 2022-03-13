using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalScripting
{
    class Jugador
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

        public bool Atacar(Atacable target)
        {
            bool victoria = false;

            if (target.esObstaculo==true)
            {
                poder += target.poder;
                victoria = true;
                return victoria;
            }

            if (target.esObstaculo == false) 
            {
                if (target.poder > poder)
                {
                    victoria = false;
                    vidas--;
                    return victoria;

                }

                if (target.poder == poder)
                {
                    victoria = false;
                    vidas--;
                    return victoria;
                }
                
                
                else if (target.poder < poder)
                {
                    
                    victoria = true;
                    poder += target.poder;
                    return victoria;
                    
                }

               
               
            }

            return victoria;
            
           
        }
    }

    

}
