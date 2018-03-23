using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RAaA.API.DTO
{
    public class PCBuildDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double TotalPrice { get; set; }
        public ProcessorDTO Processor { get; set; }
        public ICollection<RAMDTO> RAMs { get; set; }
    }
}
