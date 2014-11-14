﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Olimpiadas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public partial class Deportista
{
        public Deportista()
    {
            this.Calificaciones = new HashSet<Calificaciones>();
        }
        [Required]
        [Key]
        public int dorsal { get; set; }
        [MinLength (20)]
        [MaxLength(150)]
        [Required]

        public string nombre { get; set; }
        [Range(16,99)]
        public int edad { get; set; }
        public decimal calificacion { get; set; }
        public string email { get; set; }
        public string descripcion { get; set; }
        public System.DateTime fechaNacimiento { get; set; }
        [StringLength(3)]
        public string ISO { get; set; }

        public virtual Pais Pais { get; set; }
        public virtual ICollection<Calificaciones> Calificaciones { get; set; }
    }
}