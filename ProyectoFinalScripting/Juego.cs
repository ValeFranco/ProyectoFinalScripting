using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalScripting
{
    public class Juego
    {
        public List<Torre> listaTorres = new List<Torre>();
        public TorreJugador torreJugador;

        public Juego()
        {
    
        }

        public string LimpiarLista()
        {
            bool pasoNivel=true;
            string mensaje="No se ha ganado el nivel";
            foreach (TorreEnemigo item in listaTorres)
            {
                if (item==null)
                {
                    listaTorres.Remove(item);
                }
            }
            if (listaTorres.Count == 0)
            {
                pasoNivel = true;
            }
            if (pasoNivel)
            {
                mensaje = "Pasaste de nivel";
            }
            return mensaje;   
        }        
    }
}
