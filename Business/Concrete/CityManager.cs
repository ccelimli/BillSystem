using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CityManager : ICityService
    {
        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        //Add
        public IResult Add(City city)
        {
            _cityDal.Add(city);
            return new SuccessResult(Messages.CityAdded);
        }

        //Delete
        public IResult Delete(City city)
        {
            _cityDal.Delete(city);
            return new SuccessResult(Messages.CityDeleted);
        }

        //GetAll
        public IDataResult<List<City>> GetAll()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll(),Messages.CitiesListed);
        }

        //GetById
        public IDataResult<City> GetById(int id)
        {
            return new SuccessDataResult<City>(_cityDal.Get(c=>c.Id==id), Messages.CityListed);
        }

        //Update
        public IResult Update(City city)
        {
            _cityDal.Update(city);
            return new SuccessResult(Messages.CityUpdated);
        }
    }
}
