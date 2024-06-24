using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PetLife.Infrastructure.Data.Models
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(TypeId))]
        public virtual AnimalType AnimalType { get; set; }
        public int TypeId { get; set; }
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

        public int OwnerId { get; set; }
        public Owner AnimalOwner { get; set; }
        public int DoctorId { get; set; }
        public Doctor AnimalDoctor { get; set; }

        public ICollection<Vaccination> Vaccinations { get; set; }

        public ICollection<Deworming> Dewormings { get; set; }

        public ICollection<Treatment> Treatments { get; set; }

        public ICollection<Test> Tests { get; set; }
    }
}
