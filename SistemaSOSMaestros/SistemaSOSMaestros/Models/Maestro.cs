using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaSOSMaestros.Models
{
    public class Maestro
    {
        [Key]
        public Int32 MaestroId { get; set; }
        [Required]
        [StringLength(100)]
        public String Nombre { get; set; }

        public virtual Carrera Carrera { get; set; }
    }
}
