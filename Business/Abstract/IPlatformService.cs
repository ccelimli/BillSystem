using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPlatformService
    {
        IResult Add(Platform platform);
        IResult Delete(Platform platform);
        IResult Update(Platform platform);
        IDataResult<Platform> GetById(int id);
        IDataResult<List<Platform>> GetAll();
    }
}
