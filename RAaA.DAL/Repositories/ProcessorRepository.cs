using System;
using System.Collections.Generic;
using RAaA.DAL.Interfaces;
using RAaA.DAL.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace RAaA.DAL.Repositories
{
    public class ProcessorRepository : IRepository<Processor>
    {
        PCBuildContext db;

        public ProcessorRepository(PCBuildContext context)
        {
            db = context;
        }

        public void Create(Processor processor)
        {
            db.Processors.Add(processor);
        }

        public void Delete(int id)
        {
            Processor processor = db.Processors.Find(id);
            if(processor != null)
                db.Processors.Remove(processor);
        }

        public IEnumerable<Processor> Find(Func<Processor, bool> predicate)
        {
            return db.Processors.Where(predicate).ToList();
        }

        public Processor Get(int id)
        {
            return db.Processors.Find(id);
        }

        public IEnumerable<Processor> GetAll()
        {
            return db.Processors;
        }

        public void Update(Processor processor)
        {
            db.Entry(processor).State = EntityState.Modified;
        }
    }
}
