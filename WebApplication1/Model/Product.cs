using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
    public class Product
    {
        public int ID { get; set; }
        [Required, Display(Name = "Enter Product Name"), MaxLength(200), MinLength(5)]

        public string ProductName { get; set; }
        [Required]

        public string ShortDescription { get; set; }
        [Required, Display(Name = "Product Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required]

        public string ProducImg { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Quantity { get; set; }

        [Required]
        public string Category { get; set; }
      

    }
}

