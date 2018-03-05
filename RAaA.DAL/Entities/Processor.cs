using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace RAaA.DAL.Entities
{
    public class Processor
    {
        [Key]
        public string Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; }

        [Required]
        public double Price { get; set; }

        public ICollection<PCBuild> PCBuilds { get; set; }
    }
}
