using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {

        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal =colorDal;
        }

        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new Result(true,"Color Added");
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new Result(true, "Color deleted");
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),"Colors listed");
        }

        public IDataResult<Color> GetColorById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(r=>r.Id==id),"Color listed");
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new Result(true, "Color modified");
        }
    }
}
