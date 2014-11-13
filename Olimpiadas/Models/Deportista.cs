using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Olimpiadas.Models
{
    public class Deportista
    {
        public int Dorsal { set; get; }
        public string Nombre { set; get; }
        public int Edad { set; get; }
        public string IsoPais { set; get; }
        

        //Faltan 

        public virtual Pais Pais { set; get; }



    }
}