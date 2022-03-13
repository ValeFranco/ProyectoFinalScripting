using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalScripting
{
    class TorreEnemigo : Torre

    {
        Atacable atacable;
        internal List<Atacable> l_atacable;
        public TorreEnemigo(uint altura, Atacable atacable) : base(altura)
        {

            this.Altura = altura;
            this.atacable = atacable;
            l_atacable = new List<Atacable>((int)altura);
            l_atacable.Add(atacable);
            
        }

       internal void ReducirAltura(Atacable target)
       {
            l_atacable.Remove(target);
            Altura--;
       }

        static void LlenarTorre()
        {

        }
    }
}
