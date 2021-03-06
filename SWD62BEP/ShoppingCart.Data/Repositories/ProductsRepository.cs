﻿using ShoppingCart.Data.Context;
using ShoppingCart.Domain.Interfaces;
using ShoppingCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.Data.Repositories
{
    public class ProductsRepository : IProductRepository
    {
        readonly ShoppingCartDbContext _context;
        public ProductsRepository(ShoppingCartDbContext context)
        {
            _context = context;
        }

        public Guid AddProduct(Product p)
        {
            _context.Products.Add(p);
            _context.SaveChanges();
            return p.Id;
        }

        public void DeleteProduct(Product p)
        {
            _context.Products.Remove(p);
            _context.SaveChanges(); //this will save permanently into the database
        }

        public void DisableProduct(Guid id)
        {
            var p = GetProduct(id);
            p.Disable = true;
            _context.SaveChanges();
        }

        public Product GetProduct(Guid id)
        {
            //single of default will return one product or null
            return _context.Products.SingleOrDefault(x => x.Id == id);
        }

        public IQueryable<Product> GetProducts()
        {
            return _context.Products;
        }
    }
}
