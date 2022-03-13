 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalScripting
{
    public abstract class Torre
    {
        public uint altura;
        
        internal uint Altura 
        { get => altura; set
            { 
                if (value != 0)
                {
                    altura = value;
                }
                else
                {
                    throw new Exception("La altura de la torre no puede ser cero");
                }
            } 
        }
        public Torre(uint altura)
        {
            this.Altura = altura;
        }

      
    }
}
