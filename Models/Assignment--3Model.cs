using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment__3.Models
{
    public class Assignment__3Model : DbContext
    {
        public Assignment__3Model(DbContextOptions<Assignment__3Model> options) : base(options)
        {
        }

        public DbSet<Bike> Bikes { get; set; }
        public DbSet<Car> Cars { get; set; }

        
    
    
    }
}
