using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Veterinaria.Web.Models
{
    public class Pet
    {
        public int Id { get; set; }
        [Display(Name="Nombre")]
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Display(Name = "Tipo")]
        [Required]
        [MaxLength(50)]
        public string PetType { get; set; }
        [Display(Name = "Edad")]
        public int Age { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Color")]
        [Required]
        [MaxLength(50)]
        public string Color { get; set; }
        [Display(Name = "Raza")]
        [MaxLength(50)]
        public string Race { get; set; }
        [Display(Name = "Peso")]
        [Required]
        public decimal Weight { get; set; }
        [Display(Name = "Altura")]
        [Required]
        public decimal Height { get; set; }
        [Display(Name = "Foto")]
        public byte[] Image { get; set; }
        public int OwnerId { get; set; }
        [ForeignKey("OwnerId")]
        public Owner Owner { get; set; }
        public ICollection<Consult> Consults { get; set; }
    }
}