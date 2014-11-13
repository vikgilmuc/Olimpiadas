﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Olimpiadas.Models
{
    public class OlimpiadasContext : DbContext
    {
        public DbSet<Deportista> Deportistas { set; get; }
        public DbSet<Pais> Paises { set; get; }

    }
}