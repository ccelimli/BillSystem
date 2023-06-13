using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        //Add
        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        //Delete
        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        //GetAll
        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UsersListed);
        }

        public IDataResult<User> GetByEmail(string email)
        {
            return new SuccessDataResult<User>(_userDal.Get(user => user.Email == email), Messages.UserListed);
        }

        //GetById
        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Id == id), Messages.UserListed);
        }

        public IDataResult<User> GetByNationalityNo(string nationalityNo)
        {
            return new SuccessDataResult<User>(_userDal.Get(user => user.NationalityNo == nationalityNo));
        }

        public IDataResult<User> GetByPhoneNumber(string phoneNumber)
        {
            return new SuccessDataResult<User>(_userDal.Get(user => user.PhoneNumber == phoneNumber), Messages.UserListed);
        }

        //Update
        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            var operationResult = _userDal?.GetClaims(user);
            return new SuccessDataResult<List<OperationClaim>>(operationResult);
        }

        public IDataResult<User> setOperationClaim(User user)
        {
            throw new NotImplementedException();
        }
    }
}
