using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaSOSMaestros.Models
{
    public class Materia
    {
        [Key]
        public Int32 MateriaId { get; set; }
        [Required]
        [StringLength(100)]
        public String Nombre { get; set; }
        [Required]
        [StringLength(100)]
        public String Codigo { get; set; }
    }
}
