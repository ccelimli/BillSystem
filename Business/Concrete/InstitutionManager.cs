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
    public class InstitutionManager : IInstitutionService
    {
        IInstitutionDal _institutionDal;

        public InstitutionManager(IInstitutionDal institutionDal)
        {
            _institutionDal = institutionDal;
        }

        //Add
        public IResult Add(Institution institution)
        {
            _institutionDal.Add(institution);
            return new SuccessResult(Messages.InstitutionAdded);
        }

        //Delete
        public IResult Delete(Institution institution)
        {
           _institutionDal.Delete(institution);
            return new SuccessResult(Messages.InstitutionDeleted);
        }

        //GetAll
        public IDataResult<List<Institution>> GetAll()
        {
            return new SuccessDataResult<List<Institution>>(_institutionDal.GetAll(),Messages.InstitutionsListed);
        }

        public IDataResult<List<Institution>> GetByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Institution>>(_institutionDal.GetAll(institution=>institution.CategoryId==categoryId));
        }

        //GetById
        public IDataResult<Institution> GetById(int id)
        {
            return new SuccessDataResult<Institution>(_institutionDal.Get(i=>i.Id==id),Messages.InstitutionListed);
        }

        //Update
        public IResult Update(Institution institution)
        {
            _institutionDal.Update(institution);
            return new SuccessResult(Messages.InstitutionUpdated);
        }
    }
}
