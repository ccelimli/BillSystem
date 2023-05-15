using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFaqService
    {
        IResult Add(Faq faq);
        IResult Delete(Faq faq);
        IResult Update(Faq faq);
        IDataResult<Faq> GetById(int id);
        IDataResult<List<Faq>> GetAll();
    }
}
