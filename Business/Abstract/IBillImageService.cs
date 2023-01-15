using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBillImageService 
    {
        IResult Add(BillImage billImage);
        IResult Delete(BillImage billImage);
        IResult Update(BillImage billImage);
        IDataResult<BillImage> GetById(int id);
        IDataResult<List<BillImage>> GetAll();
    }
}
