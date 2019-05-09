using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoPets.Models
{
    public class Product
    {
        public long id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(minimum:0.01,maximum:(double)decimal.MaxValue)]
        public decimal Price { get; set; }
    }
}
