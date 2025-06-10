using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBrazorNet7.DTO
{
    public class UserDTO
    {
        public int IdUser { get; set; }

        [Required(ErrorMessage = "Enter full name")]
        public string? FullName { get; set; }

        [Required(ErrorMessage = "Enter email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Enter password")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Confirm password")]
        public string? ConfirmPassword { get; set; }

        public string? Role { get; set; }

    }
}
