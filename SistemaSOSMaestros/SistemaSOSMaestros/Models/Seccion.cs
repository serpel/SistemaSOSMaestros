using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaSOSMaestros.Models
{
    public class Seccion
    {
        [Key]
        public Int32 SeccionId { set; get; }
        [Required]
        public String Codigo { get; set; }
    }
}
