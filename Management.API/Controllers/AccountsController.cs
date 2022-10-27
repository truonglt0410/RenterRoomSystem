using Management.API.Services;
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
    [Route("account")]
    public class AccountsController : ControllerBase
    {
        private readonly AccountService _service;
        public AccountsController(AccountService service)
        {
            _service = service;
        }

        [HttpGet]       
        public async Task<List<User>> GetAccount()
        {
            return await _service.AddAllEntitiesAsync();
        }

        [HttpGet("{id}")]
        public async Task<User> GetbyId(int id)
        {
            return await _service.GetUserbyId(id);
        }
        [HttpGet("getname/{name}")]
        public async Task<User> GetbyUserName(string name)
        {
            return await _service.GetUserbyUserName(name);
        }

    }
}
