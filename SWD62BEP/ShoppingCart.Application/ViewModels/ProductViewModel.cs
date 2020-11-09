using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShoppingCart.Application.ViewModels
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public double Price { get; set; }
        public String Description { get; set; }

        public CategoryViewModel Category { get; set; }
    }
}
