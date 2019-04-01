using System.Collections.Generic;
using App.DataAccess.DbModels;
using App.Models.Models;
using App.Repositories.Infrastructure;
using App.Repositories.Interfaces;
using App.Services.Interfaces;

namespace App.Services.Services
{
    public class UserService : IUserService
    {
        readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(
            IUserRepository userRepository,
            IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }

        public List<UserModel> AllUsers()
        {
            var data = _userRepository.GetAll();
             
            return AutoMapper.Mapper.Map<List<UserModel>>(data);
        }
    }
}
