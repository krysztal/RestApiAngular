using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RAaA.API.Interfaces;
using RAaA.DAL.Interfaces;
using RAaA.DAL.Entities;

namespace RAaA.API.Data
{
    public class DbInitializer : IDbInitializer
    {
        private PCBuildContext _db;

        public DbInitializer(PCBuildContext context)
        {
            _db = context;
        }

        public void Initalize()
        {
            if(!_db.Processors.Any())
            {
                List<Processor> processors = new List<Processor>()
                {
                    new Processor()
                    {
                        Model = "5774C",
                        Price = 51.22
                    },
                    new Processor()
                    {
                        Model = "4790K",
                        Price = 329
                    }
                };
            }
        }
    }
}
