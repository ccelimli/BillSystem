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
    public class FoundationManager : IFoundationService
    {
        IFoundationDal _foundationDal;

        public FoundationManager(IFoundationDal foundationDal)
        {
            _foundationDal = foundationDal;
        }

        //Add
        public IResult Add(Foundation foundation)
        {
            _foundationDal.Add(foundation);
            return new SuccessResult(Messages.FoundationAdded);
        }

        //Delete
        public IResult Delete(Foundation foundation)
        {
            _foundationDal.Delete(foundation);
            return new SuccessResult(Messages.FoundationDeleted);
        }

        //GetAll
        public IDataResult<List<Foundation>> GetAll()
        {
           return new SuccessDataResult<List<Foundation>>(_foundationDal.GetAll(),Messages.FoundationsListed);
        }

        //GetById
        public IDataResult<Foundation> GetById(int id)
        {
            return new SuccessDataResult<Foundation>(_foundationDal.Get(f=>f.Id==id),Messages.FoundationListed);
        }

        //Update
        public IResult Update(Foundation foundation)
        {
            _foundationDal.Update(foundation);
            return new SuccessResult(Messages.FoundationUpdated);
        }
    }
}
