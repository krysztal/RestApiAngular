using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RAaA.DAL.Entities
{
    public class PCBuild
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public double TotalPrice { get; set; }

        [MaxLength(50)]
        public Processor Processor { get; set; }

        public ICollection<PCBuildRAM> PCBuildRAMs { get; set; }
    }
}
