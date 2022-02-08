using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDAL;
        public UserManager(IUserDal userDal)
        {
            _userDAL = userDal;
        }
        public IResult Add(User user)
        {
            _userDAL.Add(user);
            return new SuccessResult("User added");
            
        }

        public IResult Delete(User user)
        {
            _userDAL.Delete(user);
            return new SuccessResult("User deleted");
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDAL.GetAll(), "Users Listed");
        }

        public IDataResult<User> GetUserById(int id)
        {
            return new SuccessDataResult<User>(_userDAL.Get(u => u.Id == id));
        }

        public IResult Update(User user)
        {
            _userDAL.Update(user);
            return new SuccessResult("User updated");
        }
    }
}
