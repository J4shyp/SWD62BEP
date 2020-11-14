using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShoppingCart.Domain.Models
{
    //once something is updated here ctrl+shift+b
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public String Description { get; set; }
        [Required]

        public Category Category { get; set; }
        public string ImageUrl { get; set; }
    }
}
