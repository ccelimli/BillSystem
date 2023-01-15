using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICityService
    {
        IResult Add(City city);
        IResult Delete(City city);
        IResult Update(City city);
        IDataResult<City> GetById(int id);
        IDataResult<List<City>> GetAll();
    }
}
