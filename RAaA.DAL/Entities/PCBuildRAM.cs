using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RAaA.DAL.Entities
{
    public class PCBuildRAM
    {
        [Key]
        public int Id { get; set; }

        public int PCBuildId { get; set; }
        public PCBuild PCBuild { get; set; }

        public int RAMId { get; set; }
        public RAM RAM { get; set; }
    }
}
