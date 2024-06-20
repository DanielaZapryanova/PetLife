using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

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
    }
}
