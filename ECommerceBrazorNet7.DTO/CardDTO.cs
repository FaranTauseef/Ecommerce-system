using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBrazorNet7.DTO
{
    public class CardDTO
    {
        [Required(ErrorMessage = "Enter cardholder")]
        public string? Holder { get; set; }

        [Required(ErrorMessage = "Enter number")]
        public string? Number { get; set; }

        [Required(ErrorMessage = "Enter validity")]
        public string? Validity { get; set; }

        [Required(ErrorMessage = "Enter security code")]
        public string? CVV { get; set; }
    }
}
