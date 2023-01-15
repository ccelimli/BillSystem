using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityRepository
{
    public class AnimalShelterDal:EntityRepositoryBase<AnimalShelter,BillSystemContext>,IAnimalShelterDal
    {
        public List<AnimalShelterDetailDto> GetAnimalShelterDetails()
        {
            using (BillSystemContext context=new BillSystemContext())
            {
                var GetAnimalShelterDetails = from animalShelter in context.AnimalShelters
                                     join platform in context.Platforms
                                     on animalShelter.PlatformId equals platform.Id
                                     join bank in context.Banks
                                     on animalShelter.BankId equals bank.Id
                                     join city in context.Cities
                                     on animalShelter.CityId equals city.Id
                                     select new AnimalShelterDetailDto
                                     {
                                         PlatformName = platform.Name,
                                         CityName = city.Name,
                                         AnimalShelterName = animalShelter.Name,
                                         BankName = bank.Name,
                                         IBAN = animalShelter.Iban
                                     };
                return GetAnimalShelterDetails.ToList();
            }
        }
    }
}
