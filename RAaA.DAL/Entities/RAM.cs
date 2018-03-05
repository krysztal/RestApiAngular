using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace RAaA.DAL.Entities
{
    public class RAM
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; }

        [Required]
        public double Price { get; set; }
        public ICollection<PCBuildRAM> PCBuildRAMs { get; set; }
    }
}
