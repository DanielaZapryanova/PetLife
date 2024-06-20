using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetLife.Infrastructure.Data.Models
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }
        public string? Image { get; set; }

        [Required]
        [MaxLength(30)]
        public string? Name { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string? Alergies { get; set; }

        [Required]
        public string? Gender { get; set; }

        [Required]
        public DateTime Castration { get; set; }

        [Required]
        public string? Other { get; set; }
    }
}
