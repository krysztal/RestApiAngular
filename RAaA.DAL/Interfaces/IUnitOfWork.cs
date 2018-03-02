using System;
using System.Collections.Generic;
using System.Text;
using RAaA.DAL.Entities;

namespace RAaA.DAL.Interfaces
{
    interface IUnitOfWork : IDisposable
    {
        IRepository<PCBuild> PCBuilds { get; }
        IRepository<Processor> Processors { get; }
        IRepository<RAM> RAMs { get; }

        void Save();
    }
}
