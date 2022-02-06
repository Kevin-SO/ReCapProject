﻿using Core.DataAccess.EF;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EF
{
    public class EfCarDal : EfEntityRepositoryBase<Car, MyDbContext>, ICarDal
    {
        public List<CarDetailDto> GetProductDetails()
        {
            using (MyDbContext context = new MyDbContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.Id
                             join r in context.Colors on c.ColorId equals r.Id
                             select new CarDetailDto
                             {
                                 // CarName, BrandName, ColorName, DailyPrice
                                 CarName = c.Description,
                                 BrandName = b.Name,
                                 ColorName = r.Name,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
                }
    }
}
