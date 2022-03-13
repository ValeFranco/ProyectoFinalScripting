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

        public void LimpiarLista()
        {
            foreach(Torre item in l_torres)
            {
                if (item == null)
                {
                    l_torres.Remove(item);
                }
            }
            
        }
        
    }

}
