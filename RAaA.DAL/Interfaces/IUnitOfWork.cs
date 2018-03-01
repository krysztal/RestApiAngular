using System;
using System.Collections.Generic;
using System.Text;
using RAaA.DAL.Entities;

namespace RAaA.DAL.Interfaces
{
    interface IUnitOfWork
    {
        IRepository<PCBuild> PCBuilds { get; }
        IRepository<PCBuild> Processors { get; }
        IRepository<PCBuild> RAMs { get; }

        void Save();
    }
}
