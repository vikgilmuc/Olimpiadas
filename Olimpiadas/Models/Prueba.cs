//------------------------------------------------------------------------------
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
    
    public partial class Prueba
    {
        public Prueba()
        {
            this.Calificaciones = new HashSet<Calificaciones>();
        }
        [Required]
        [Key]
        []
        public int Id { get; set; }
        public string nombre { get; set; }
    
        public virtual ICollection<Calificaciones> Calificaciones { get; set; }
    }
}