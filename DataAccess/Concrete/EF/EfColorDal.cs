﻿using Core.DataAccess.EF;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EF
{
    public class EfColorDal : EfEntityRepositoryBase<Color, MyDbContext>, IColorDal
    {
       

        
    }
}
