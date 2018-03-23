using RAaA.API.DTO;
using System.Collections.Generic;

namespace RAaA.API.Interfaces
{
    public interface IPCBuilderService
    {
        void CreateBuild(PCBuildDTO buildDto);
        void DeleteBuild(int id);
        PCBuildDTO GetBuild(int id);
        IEnumerable<PCBuildDTO> GetBuilds();
        void Dispose();
    }
}
