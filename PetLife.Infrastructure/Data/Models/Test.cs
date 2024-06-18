using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

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
        public string Name { get; set; }

        public DateTime DateOfConduction { get; set; }

        public string Path { get; set; }

        //public Pet Pet { get; set; }
    }
}
