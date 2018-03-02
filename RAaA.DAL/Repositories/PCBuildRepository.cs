using System;
using System.Collections.Generic;
using System.Linq;
using RAaA.DAL.Interfaces;
using RAaA.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace RAaA.DAL.Repositories
{
    public class PCBuildRepository : IRepository<PCBuild>
    {
        PCBuildContext db;

        public PCBuildRepository(PCBuildContext context)
        {
            db = context;
        }

        public void Create(PCBuild pcbuild)
        {
            db.PCBuilds.Add(pcbuild);
        }

        public void Delete(int id)
        {
            PCBuild build = db.PCBuilds.Find(id);
            if(build != null)
                db.PCBuilds.Remove(build);
        }

        public IEnumerable<PCBuild> Find(Func<PCBuild, bool> predicate)
        {
            return db.PCBuilds.Where(predicate).ToList();
        }

        public PCBuild Get(int id)
        {
            return db.PCBuilds.Find(id);
        }

        public IEnumerable<PCBuild> GetAll()
        {
            return db.PCBuilds;
        }

        public void Update(PCBuild pcbuild)
        {
            db.Entry(pcbuild).State = EntityState.Modified;
        }
    }
}
