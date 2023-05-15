using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public IDataResult<List<BillDetailDto>> GetBillDetails()
        {
            try
            {
                return new SuccessDataResult<List<BillDetailDto>>(_billDal.GetBillDetails(),Messages.BillsListed);
            }catch (Exception ex) {
                return new ErrorDataResult<List<BillDetailDto>>(Messages.Error);
            }
        }

        public IDataResult<List<BillDetailDto>> GetBillDetailsByCategoryId(int categoryId)
        {
            try
            {
                return new SuccessDataResult<List<BillDetailDto>>(_billDal.GetBillDetailsByCategoryId(categoryId), Messages.BillListed);
            }
            catch
            {
                return new ErrorDataResult<List<BillDetailDto>>(Messages.Error);
            }
        }

        //GetById
        public IDataResult<Bill> GetById(int id)
        {
            return new SuccessDataResult<Bill>(_billDal.Get(b => b.Id == id), Messages.BillListed);
        }

        public IDataResult<List<Bill>> GetCategoryById(int categoryId)
        {
            return new SuccessDataResult<List<Bill>>(_billDal.GetAll(b => b.CategoryId == categoryId), Messages.BillListed);
        }

        

        //Update
        public IResult Update(Bill bill)
        {
            _billDal.Update(bill);
            return new SuccessResult(Messages.BillUpdated);
        }
    }
}
