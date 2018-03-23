using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RAaA.API.DTO;
using RAaA.API.Interfaces;
using RAaA.DAL.Entities;
using RAaA.DAL.Interfaces;
using AutoMapper;

namespace RAaA.API.Services
{
    public class PCBuilderService : IPCBuilderService
    {
        private IUnitOfWork uow;

        public PCBuilderService(IUnitOfWork unitOfWork)
        {
            uow = unitOfWork;
        }

        public void CreateBuild(PCBuildDTO buildDto)
        {
            //Mapper.Initialize(cfg => cfg.CreateMap<PCBuildDTO, PCBuild>().ConstructUsing);

            //uow.PCBuilds.Create()
        }

        public void DeleteBuild(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            uow.Dispose();
        }

        public PCBuildDTO GetBuild(int id)
        {
            var build = uow.PCBuilds.Get(id);
            Mapper.Initialize(x => x.CreateMap<PCBuild, PCBuildDTO>());
            var buildDTO = Mapper.Map<PCBuild, PCBuildDTO>(build);
            return buildDTO;
        }

        public IEnumerable<PCBuildDTO> GetBuilds()
        {
            throw new NotImplementedException();
        }

        public void MakeBuild()
        {
            throw new NotImplementedException();
        }
    }
}
