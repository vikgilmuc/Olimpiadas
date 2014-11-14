using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Olimpiadas.Models
{
    public class Pais
    {
        public string ISO { set; get; }
        public string Nombre { set; get; }

        public virtual ICollection<Deportista> Deportistas { set; get; }

    }
}