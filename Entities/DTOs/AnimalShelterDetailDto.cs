using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class AnimalShelterDetailDto : IEntity
    {
        public string PlatformName { get; set; }
        public string CityName { get; set; }
        public string AnimalShelterName { get; set; }
        public string BankName { get; set; }
        public string IBAN { get; set; }
    }
}
