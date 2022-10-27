using Management.API.Services;
using Management.Domain.Base;
using Management.Domain.DataModel;
using Management.Domain.Departments;
using Management.Domain.Users;
using Management.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management.API.Controllers
{
    [ApiController]
    [Route("building")]
    public class BuildingsController : ControllerBase
    {
        private readonly BuildingService _service;
        public BuildingsController(BuildingService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<ResultDataModel> Addbuilding([FromForm] BuildingModel model)
        {
            return await _service.AddBuilding(model);
        }
    }
}
