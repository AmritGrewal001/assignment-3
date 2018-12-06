using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment__3.Models
{
    public class Car
    {
        [Key]
        public int Cars { get; set; }

        [Required]
        [StringLength(10)]
        public string Car1 { get; set; }

        [Required]
        [StringLength(10)]
        public string Car2 { get; set; }

        [Required]
        [StringLength(10)]
        public string Car3 { get; set; }

    }
}
