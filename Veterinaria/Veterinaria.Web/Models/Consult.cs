using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veterinaria.Web.Models
{
    public class Consult
    {
        public int Id { get; set; }
        [Display(Name = "Fecha de Consulta")]
        [Required]
        public DateTime ConsultDate { get; set; }
        [Display(Name = "Descripción")]
        [Required]
        public string Description { get; set; }
        [Display(Name = "Tipo de Consulta")]
        [Required]
        public string ConsultType { get; set; }
        public Veterinary Veterinary { get; set; }
        public Pet Pet { get; set; }
    }
}