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
        internal List<Atacable> listaAtacable;
        bool destruible;
        public TorreEnemigo(uint altura, Atacable atacable) : base(altura)
        {
            this.Altura = altura;
            this.atacable = atacable;
            listaAtacable = new List<Atacable>((int)altura);
            listaAtacable.Add(atacable);
            destruible = false;
        }
       internal void ReducirAltura(Atacable target)
       {
            listaAtacable.Remove(target);
            altura--;
       }
    }
}
