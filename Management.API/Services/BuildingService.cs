using Management.Domain.Base;
using Management.Domain.Buildings;
using Management.Domain.DataModel;
using Management.Domain.Departments;
using Management.Domain.Interfaces;
using Management.Domain.Users;
using Management.Infrastructure.Repositories;
using System.Threading.Tasks;

namespace Management.API.Services
{
    public class BuildingService
    {
        private readonly IBuildingRepository _buildingRepository;
        public BuildingService(IBuildingRepository buildingRepository)
        {
            _buildingRepository = buildingRepository;
          
        }
        public async Task<ResultDataModel> AddBuilding(BuildingModel model)
        {
            var result = _buildingRepository.AddBuilding(model);
            return await result;
        }
    }
}
