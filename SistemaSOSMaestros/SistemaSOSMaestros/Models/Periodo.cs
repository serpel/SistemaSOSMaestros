using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaSOSMaestros.Models
{
    public class Periodo
    {
        [Key]
        public Int32 PeriodoId { get; set; }
        [Required]
        public Int32 Anio { get; set; }
        [Required]
        [StringLength(100)]
        public String Nombre { get; set; }
    }
}
