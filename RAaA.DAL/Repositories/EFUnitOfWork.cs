using System;
using System.Collections.Generic;
using System.Text;
using RAaA.DAL.Interfaces;
using RAaA.DAL.Entities;

namespace RAaA.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        PCBuildContext db;
        PCBuildRepository pcBuildRepository;
        ProcessorRepository processorRepository;
        RAMRepository ramRepository;
        bool disposed = false;

        public EFUnitOfWork(PCBuildContext context)
        {
            db = context;
        }

        public IRepository<PCBuild> PCBuilds
        {
            get
            {
                if (pcBuildRepository == null)
                    pcBuildRepository = new PCBuildRepository(db);
                return pcBuildRepository;
            }
        }
        public IRepository<Processor> Processors
        {
            get
            {
                if (processorRepository == null)
                    processorRepository = new ProcessorRepository(db);
                return processorRepository;
            }
        }
        public IRepository<RAM> RAMs
        {
            get
            {
                if (ramRepository == null)
                    ramRepository = new RAMRepository(db);
                return ramRepository;

            }
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
