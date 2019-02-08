using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaSOSMaestros.Models
{
    public class Carrera
    {
        [Key]
        public Int32 CarreraId { get; set; }
        [Required]
        [StringLength(100)]
        public String Nombre { get; set; }
        [Required]
        [StringLength(10)]
        public String Codigo { get; set; }
    }
}