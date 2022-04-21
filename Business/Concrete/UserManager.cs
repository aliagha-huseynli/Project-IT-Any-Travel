using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _dal;

        public UserManager(IUserDal dal)
        {
            _dal = dal;
        }
    }
}
