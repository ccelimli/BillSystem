using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFagService
    {
        IResult Add(Fag fag);
        IResult Delete(Fag fag);
        IResult Update(Fag fag);
        IDataResult<Fag> GetById(int id);
        IDataResult<List<Fag>> GetAll();
    }
}
