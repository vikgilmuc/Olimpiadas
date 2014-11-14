using Olimpiadas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Olimpiadas.Models
{

    public class PruebaPosicion
    {
        public String nombrePrueba { set; get; }
        public int posicion {set; get;}
    
    }
    public class DeportistaConPruebas
    {
        public Deportista deportista;
        private List<PruebaPosicion> PruebasPosiciones {set;get;}


    }
}