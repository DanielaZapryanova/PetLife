using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetLife.Infrastructure.Data.Models
{
    public class Deworming
    {
        [Key]
        [Comment("Id of the dewormings.")]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        [ForeignKey(nameof(AnimalId))]
        public virtual Animal Animal { get; set; }

        public int AnimalId { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
        public DateTime DateOfTreatment { get; set; }
    }
}
