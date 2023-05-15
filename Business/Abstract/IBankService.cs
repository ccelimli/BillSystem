using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBankService
    {
        IResult Add(Bank bank);
        IResult Delete(Bank bank);
        IResult Update(Bank bank);
        IDataResult<Bank> GetById(int id);
        IDataResult<List<Bank>> GetAll();
    }
}
