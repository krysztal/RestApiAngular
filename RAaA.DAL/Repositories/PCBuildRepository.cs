using System;
using System.Collections.Generic;
using System.Text;
using RAaA.DAL.Interfaces;
using RAaA.DAL.Entities;

namespace RAaA.DAL.Repositories
{
    public class PCBuildRepository : IRepository<PCBuild>
    {
        PCBuildContext db;

        public PCBuildRepository(PCBuildContext context)
        {
            db = context;
        }

        public void Create(PCBuild item)
        {
            db.PCBuilds.Add(item);
        }

        public void Delete(int id)
        {
            PCBuild build = db.PCBuilds.Find(id);
            if(build != null)
                db.PCBuilds.Remove(build);
        }

        public IEnumerable<PCBuild> Find(Func<PCBuild, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public PCBuild Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PCBuild> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(PCBuild item)
        {
            throw new NotImplementedException();
        }
    }
}
