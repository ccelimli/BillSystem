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
    public class BillManager : IBillService
    {
        IBillDal _billDal;

        public BillManager(IBillDal billDal)
        {
            _billDal = billDal;
        }

        //Add
        public IResult Add(Bill bill)
        {
            _billDal.Add(bill);
            return new SuccessResult(Messages.BillAdded);
        }

        //Delete
        public IResult Delete(Bill bill)
        {
            _billDal.Delete(bill);
            return new SuccessResult(Messages.BillDeleted);
        }

        //GetAll
        public IDataResult<List<Bill>> GetAll()
        {
            return new SuccessDataResult<List<Bill>>(_billDal.GetAll(),Messages.BillsListed); 
        }

        //GetById
        public IDataResult<Bill> GetById(int id)
        {
            return new SuccessDataResult<Bill>(_billDal.Get(b => b.Id == id), Messages.BillListed);
        }

        //Update
        public IResult Update(Bill bill)
        {
            _billDal.Update(bill);
            return new SuccessResult(Messages.BillUpdated);
        }
    }
}
