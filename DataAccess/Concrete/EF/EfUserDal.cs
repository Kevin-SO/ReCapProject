using Core.DataAccess.EF;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EF
{
    public class EfUserDal: EfEntityRepositoryBase<User, MyDbContext>, IUserDal
    {
    }
}
