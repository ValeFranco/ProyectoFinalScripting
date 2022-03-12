 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalScripting
{
    public abstract class Torre
    {
        private uint altura;
        protected uint Altura { get => altura; set => altura = value; }
        public Torre(uint altura)
        {
            this.Altura = altura;
        }

        internal static void DestruirTorre()
        {

        }
    }
}
