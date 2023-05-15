using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInstitutionService
    {
        IResult Add(Institution institution);
        IResult Delete(Institution institution);
        IResult Update(Institution institution);
        IDataResult<Institution> GetById(int id);
        IDataResult<List<Institution>> GetByCategoryId(int categoryId);
        IDataResult<List<Institution>> GetAll();
    }
}
