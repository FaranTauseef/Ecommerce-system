using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceBrazorNet7.DTO
{
    public class ProductDTO
    {
        public int IdProduct { get; set; }

        [Required(ErrorMessage = "Enter product name")]
        public string? NameProduct { get; set; }

        [Required(ErrorMessage = "Enter a description")]
        public string? Description { get; set; }

        public int? IdCategory { get; set; }

        [Required(ErrorMessage = "Enter the price")]
        public decimal? Price { get; set; }

        [Required(ErrorMessage = "Enter the offer price")]
        public decimal? OfferPrice { get; set; }

        [Required(ErrorMessage = "Enter the quantity")]
        public int? Amount { get; set; }

        [Required(ErrorMessage = "Enter the image")]
        public string? Picture { get; set; }

        public DateTime? CreationDate { get; set; }

        public virtual CategoryDTO? IdCategoryNavigation { get; set; }

    }
}
