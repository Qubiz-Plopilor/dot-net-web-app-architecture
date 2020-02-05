using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.Core.Domain.Contracts;
using WebApp.Core.Domain.Contracts.Exceptions;
using WebApp.Core.Domain.Entities;
using WebApp.Core.Domain.Services;
using WebApp.Core.Services.Contracts;
using WebApp.Core.Services.Contracts.Models;

namespace WebApp.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        //public readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<UserInfoModel> GetUserById(int id)
        {
            var user =  _unitOfWork.UserRepository.GetById(id);
            return new UserInfoModel();
            //throw new EntityNotFoundException($"User with Id = {id} not found!");
        }

        public async Task<UserInfoModel> AddUser(UserInfoModel userInfoModel)
        {
            //savechanges unitofwork=>commit
            
            _unitOfWork.Commit();

            throw new EntityNotFoundException($"User cannot be added!");
        }
    }
}
