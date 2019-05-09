using ContosoPets.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoPets.Data
{

    // ContosoPets specific implementation of EFCore DbContext object. 
    // ContosoPetsContext class provides access to an in-memory database.
    public class ContosoPetsContext : DbContext
    {
        public ContosoPetsContext(DbContextOptions<ContosoPetsContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
