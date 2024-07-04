using PetLife.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace PetLife.Infrastructure.Data.Models
{
    public class Animal
    {
        public int Id { get; set; }

        [ForeignKey(nameof(TypeId))]
        public virtual AnimalType AnimalType { get; set; }
        public int TypeId { get; set; }
        public string? Image { get; set; }

        public string? Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string? Alergies { get; set; }

        public string? Gender { get; set; }

        public DateTime Castration { get; set; }

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

