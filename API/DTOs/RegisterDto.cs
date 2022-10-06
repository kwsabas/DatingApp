using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class RegisterDto
    {
        // Keyword [Required] demands a name from the user.
        [Required]
        public string Username {get; set;}

        // Keyword [Required] demands a password from the user.
        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string Password {get; set;}
    }
}