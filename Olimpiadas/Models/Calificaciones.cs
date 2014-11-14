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
    
    public partial class Calificaciones
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public int dorsal { get; set; }
        [Required]
        public int idPrueba { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}", ApplyFormatInEditMode = true)]
        public string fecha { get; set; }
        [Range (1,3)]
        public int posicion { get; set; }
    
        public virtual Deportista Deportista { get; set; }
        public virtual Prueba Prueba { get; set; }
    }
}
