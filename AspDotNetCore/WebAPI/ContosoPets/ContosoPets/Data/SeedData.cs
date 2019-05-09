using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoPets.Models;

namespace ContosoPets.Data
{
    public static class SeedData
    {
        public static void Initialize(ContosoPetsContext _context) {
            if (!_context.Products.Any())
            {
                _context.Products.AddRange(
                    new Product
                    {
                        Name = "Bone",
                        Price = 20
                    },
                    new Product
                    {
                        Name = "Belt",
                        Price = 10
                    }
                    );
                _context.SaveChanges();
            }
        }
    }
}
