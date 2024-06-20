using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetLife.Infrastructure.Data.Models
{
    public class Owner
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string? Telephone { get; set; }

        [Required]
        public string? Email {  get; set; }

        //[Key]
        //public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
       
    }
}
