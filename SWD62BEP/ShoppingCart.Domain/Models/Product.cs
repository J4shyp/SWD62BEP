using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShoppingCart.Domain.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public String Description { get; set; }
        [Required]

        public Category Category { get; set; }
    }
}
