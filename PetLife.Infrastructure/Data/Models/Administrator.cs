using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetLife.Infrastructure.Data.Models
{
    public class Administrator
    {
        [Key]
        public string? Username { get; set; }

        [Required]
        public string? Password { get; set; }

    }
}
