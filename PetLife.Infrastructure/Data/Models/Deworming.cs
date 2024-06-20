using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
        public DateTime DateOfTreatment { get; set; }
    }
}
