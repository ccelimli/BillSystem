using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBillService
    {
        IResult Add(Bill bill);
        IResult Delete(Bill bill);
        IResult Update(Bill bill);
        IDataResult<Bill> GetById(int id);
        IDataResult<List<Bill>> GetAll();
        IDataResult<List<BillDetailDto>> GetBillDetails();
        IDataResult<List<Bill>> GetCategoryById(int categoryId);
        IDataResult<List<BillDetailDto>> GetBillDetailsByCategoryId(int categoryId);
    }
}
