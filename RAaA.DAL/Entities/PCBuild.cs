using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RAaA.DAL.Entities
{
    public class PCBuild
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public double TotalPrice { get; set; }

        public ICollection<Processor> Processor { get; set; }
        public ICollection<RAM> RAM { get; set; }
    }
}
