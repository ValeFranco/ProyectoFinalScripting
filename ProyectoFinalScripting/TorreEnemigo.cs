using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalScripting
{
    public class TorreEnemigo : Torre

    {
        Atacable atacable;
        internal List<Atacable> l_atacable;
        bool destruible;
        public TorreEnemigo(uint altura, Atacable atacable) : base(altura)
        {

            this.Altura = altura;
            this.atacable = atacable;
            l_atacable = new List<Atacable>((int)altura);
            l_atacable.Add(atacable);
            destruible = false;
            
            
        }

       internal void ReducirAltura(Atacable target)
       {
            l_atacable.Remove(target);
            altura--;

       }

        static void LlenarTorre()
        {

        }
    }
}
