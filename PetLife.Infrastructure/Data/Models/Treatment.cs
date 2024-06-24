using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetLife.Infrastructure.Data.Models
{
    /// <summary>
    /// Treatments.
    /// </summary>
    [Comment("Treatments")]
    public class Treatment
    {
        [Key]
        [Comment("Id of the treatments.")]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
        public DateTime DateOfTreatment { get; set; }

        public int AnimalId { get; set; }

        [Required]
        [ForeignKey(nameof(AnimalId))]
        public Animal Animal { get; set; }
    }
}
