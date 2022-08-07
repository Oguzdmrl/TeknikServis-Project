﻿using Business.Abstract;
using DataAccess.Abstract;
using Entitites.Concrete;
using Entitites.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public List<RolesDto> GetAllRolesDTO()
        {
            return _userDal.GetAllRolesDTO();
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u=> u.Email == email);
        }

        public List<OperationClaim> GetClaims(User user)
        {
           return _userDal.GetClaims(user);
        }

       
    }
}