using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetLife.Infrastructure.Data.Models
{
    /// <summary>
    /// Tests.
    /// </summary>
    [Comment("Tests")]
    public class Test
    {
        [Key]
        [Comment("Id of the test.")]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
        public DateTime DateOfConduction { get; set; }

        [Required]
        public string? Path { get; set; }

        public  int AnimalId { get; set; }
        [Required]
        [ForeignKey(nameof(AnimalId))]
        public virtual Animal Animal { get; set;}
    }
}
