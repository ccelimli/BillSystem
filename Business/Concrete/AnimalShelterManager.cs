using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
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
    public class AnimalShelterManager : IAnimalShelterService
    {
        IAnimalShelterDal _animalShelterDal;

        public AnimalShelterManager(IAnimalShelterDal animalShelterDal)
        {
            _animalShelterDal = animalShelterDal;
        }

        //Add
        [ValidationAspect(typeof(AnimalShelterValidator))]
        public IResult Add(AnimalShelter animalShelter)
        {
            _animalShelterDal.Add(animalShelter);
            return new SuccessResult(Messages.AnimalShelterAdded);
        }

        //Delete
        public IResult Delete(AnimalShelter animalShelter)
        {
            _animalShelterDal.Delete(animalShelter);
            return new SuccessResult(Messages.AnimalShelterDeleted);
        }

        //GetAll
        public IDataResult<List<AnimalShelter>> GetAll()
        {
            return new SuccessDataResult<List<AnimalShelter>>(_animalShelterDal.GetAll(),Messages.AnimalSheltersListed);
        }

        public IDataResult<List<AnimalShelterDetailDto>> GetAnimalShelterDetails()
        {
            return new SuccessDataResult<List<AnimalShelterDetailDto>>(_animalShelterDal.GetAnimalShelterDetails(), Messages.AnimalSheltersListed);
        }

        //GetById
        public IDataResult<AnimalShelter> GetById(int id)
        {
            return new SuccessDataResult<AnimalShelter>(_animalShelterDal.Get(a => a.Id == id), Messages.AnimalShelterListed);
        }

        [ValidationAspect(typeof(AnimalShelterValidator))]
        //Update
        public IResult Update(AnimalShelter animalShelter)
        {
            _animalShelterDal.Update(animalShelter);
            return new SuccessResult(Messages.AnimalShelterUpdated);
        }
    }
}
