using Management.Domain.Departments;
using Management.Domain.Interfaces;
using Management.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Management.API.Services
{
    public class AccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IUserRepository _userRepository;

        public AccountService(IUnitOfWork unitOfWork
            , IDepartmentRepository departmentRepository
            , IUserRepository userRepository)
        {
            _unitOfWork = unitOfWork;
            _departmentRepository = departmentRepository;
            _userRepository = userRepository;
        }

        public async Task<List<User>> AddAllEntitiesAsync()
        {
            var user = _userRepository.NewUser();
            return await user;
        }
        public async Task<User> GetUserbyId(int id)
        {
            var user = _userRepository.GetUserbyId(id);
            return await user;
        }
        public async Task<User> GetUserbyUserName(string name)
        {
            var username = _userRepository.GetUserbyName(name);
            return await username;
        }
             
    }
}
