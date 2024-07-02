using PetLife.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PetLife.Models
{
    public class AddAnimalViewModels
    {
        [Required]
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
        public int VaccineId { get; set; }
        public int DoctorId { get; set; }
        public int DewormingId { get; set; }
        public int TreatmentId { get; set; }
        public int TestId { get; set; }


        public IList<VaccinationViewModel> PossibleVaccinations { get; set; }

        public IList<DewormingViewModel> PossibleDewormings { get; set; }

        public IList<TreatmentViewModel> PossibleTreatments { get; set; }

        public IList<TestViewModelt> PossibleTests { get; set; }

        public IList<OwnerViewModel> PossibleOwner { get; set; }

        public IList<DoctorViewModel> PossibleDoctor { get; set; }

        public IList<AnimalTypeViewModelt> PossibleAnimalType { get; set; }
    }
}
