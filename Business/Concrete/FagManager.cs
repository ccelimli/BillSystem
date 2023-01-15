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
    public class FagManager : IFagService
    {
        IFagDal _fagDal;

        public FagManager(IFagDal fagDal)
        {
            _fagDal = fagDal;
        }

        //Add
        public IResult Add(Fag fag)
        {
            _fagDal.Add(fag);
            return new SuccessResult(Messages.FagAdded);
        }

        //Delete
        public IResult Delete(Fag fag)
        {
            _fagDal.Delete(fag);
            return new SuccessResult(Messages.FagDeleted);
        }

        //GetAll
        public IDataResult<List<Fag>> GetAll()
        {
            return new SuccessDataResult<List<Fag>>(_fagDal.GetAll(), Messages.FagsListed);
        }

        //GetById
        public IDataResult<Fag> GetById(int id)
        {
            return new SuccessDataResult<Fag>(_fagDal.Get(f => f.Id == id),Messages.FagListed);
        }

        //Update
        public IResult Update(Fag fag)
        {
            _fagDal.Update(fag);
            return new SuccessResult(Messages.FagUpdated);
        }
    }
}
