using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;


namespace Business.Concrete
{
    public class BankManager : IBankService
    {
        IBankDal _bankDal;

        public BankManager(IBankDal bankDal)
        {
            _bankDal = bankDal;
        }

        //Add
        public IResult Add(Bank bank)
        {
            _bankDal.Add(bank);
            return new SuccessResult(Messages.BankAdded);
        }

        //Delete
        public IResult Delete(Bank bank)
        {
            _bankDal.Delete(bank);
            return new SuccessResult(Messages.BankDeleted);
        }

        //GetAll
        public IDataResult<List<Bank>> GetAll()
        {
            return new SuccessDataResult<List<Bank>>(_bankDal.GetAll(),Messages.BanksListed);
        }

        //GetById
        public IDataResult<Bank> GetById(int id)
        {
            return new SuccessDataResult<Bank>(_bankDal.Get(b => b.Id == id),Messages.BankListed);
        }

        //Update
        public IResult Update(Bank bank)
        {
            _bankDal.Update(bank);
            return new SuccessResult(Messages.BankUpdated);
        }
    }
}
