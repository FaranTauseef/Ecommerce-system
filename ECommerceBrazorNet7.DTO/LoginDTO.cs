using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBrazorNet7.DTO
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Enter email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Enter password")]
        public string? Password { get; set; }
    }
}
