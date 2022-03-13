using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalScripting
{
    public class Atacable
    {
        
        internal uint poder;
        internal bool esObstaculo;

        public Atacable(bool esObstaculo, uint poder)
        {
            this.esObstaculo = esObstaculo;
            Poder = poder;
        }

        public uint Poder { get => poder; set

            {
                if (value > 0)
                    poder = value;
                else
                    throw new Exception("el poder debe ser mayor a cero");
            }
        }
    }
}
