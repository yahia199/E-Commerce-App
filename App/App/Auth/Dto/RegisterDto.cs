using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App.Auth.Dto
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "You have missed to fill the username")]
        [Display(Name = "User Name")]
        [MinLength(3)]
        public string UserName { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
