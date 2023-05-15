using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FaqManager : IFaqService
    {
        IFaqDal _faqDal;

        public FaqManager(IFaqDal faqDal)
        {
            _faqDal = faqDal;
        }

        //Add
        public IResult Add(Faq faq)
        {
            _faqDal.Add(faq);
            return new SuccessResult(Messages.FaqAdded);
        }

        //Delete
        public IResult Delete(Faq faq)
        {
            _faqDal.Delete(faq);
            return new SuccessResult(Messages.FaqDeleted);
        }

        //GetAll
        public IDataResult<List<Faq>> GetAll()
        {
            return new SuccessDataResult<List<Faq>>(_faqDal.GetAll(), Messages.FaqsListed);
        }

        //GetById
        public IDataResult<Faq> GetById(int id)
        {
            return new SuccessDataResult<Faq>(_faqDal.Get(f => f.Id == id),Messages.FaqListed);
        }

        //Update
        public IResult Update(Faq faq)
        {
            _faqDal.Update(faq);
            return new SuccessResult(Messages.FaqUpdated);
        }
    }
}
