using Management.Domain.Base;
using Management.Domain.DataModel;
using Management.Domain.Departments;
using Management.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Management.Domain.Buildings
{
    public interface IBuildingRepository 
    {
        Task<ResultDataModel> AddBuilding(BuildingModel model);
    }
}
