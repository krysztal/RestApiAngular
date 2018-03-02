using System;
using System.Collections.Generic;
using RAaA.DAL.Interfaces;
using RAaA.DAL.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace RAaA.DAL.Repositories
{
    public class RAMRepository : IRepository<RAM>
    {
        PCBuildContext db;

        public RAMRepository(PCBuildContext context)
        {
            db = context;
        }

        public void Create(RAM ram)
        {
            db.RAMs.Add(ram);
        }

        public void Delete(int id)
        {
            RAM ram = db.RAMs.Find(id);
            db.RAMs.Remove(ram);
        }

        public IEnumerable<RAM> Find(Func<RAM, bool> predicate)
        {
            return db.RAMs.Where(predicate).ToList();
        }

        public RAM Get(int id)
        {
            return db.RAMs.Find(id);
        }

        public IEnumerable<RAM> GetAll()
        {
            return db.RAMs;
        }

        public void Update(RAM ram)
        {
            db.Entry(ram).State = EntityState.Modified;
        }
    }
}
