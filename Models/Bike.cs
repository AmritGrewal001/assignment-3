using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment__3.Models
{
    public class Bike {
        
            [Key]
            public int Bikes { get; set; }

            [Required]
            [StringLength(10)]
            public string Bike1 { get; set; }

            [Required]
            [StringLength(10)]
            public string Bike2 { get; set; }

            [Required]
            [StringLength(10)]
            public string Bike3 { get; set; }

        }
    }
