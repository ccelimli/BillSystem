using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAnimalShelterService
    {
        IResult Add(AnimalShelter animalShelter);
        IResult Delete(AnimalShelter animalShelter);
        IResult Update(AnimalShelter animalShelter);
        IDataResult<AnimalShelter> GetById(int id);
        IDataResult<List<AnimalShelter>> GetAll();
        IDataResult<List<AnimalShelterDetailDto>> GetAnimalShelterDetails();
    }
}
