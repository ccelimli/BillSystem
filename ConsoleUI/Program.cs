using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityRepository;
using Entities.Concrete;

CityManager cityManager = new CityManager(new CityDal());
foreach (var item in cityManager.GetAll().Data)
{
    Console.WriteLine(item.Name);
}
