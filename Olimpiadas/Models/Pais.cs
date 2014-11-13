using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Olimpiadas.Models
{
    public class Pais
    {
        public string ISO { set; get; }
        public string Nombre { set; get; }

        public virtual ICollection<Deportista> Deportistas { set; get; }

    }
}