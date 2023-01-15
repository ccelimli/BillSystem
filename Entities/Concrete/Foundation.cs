using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Foundation : IEntity
    {
        public int Id { get; set; }
        public int PlatformId { get; set; }
        public int BankId { get; set; }
        public string Name { get; set; }
        public string Iban { get; set; }
    }
}
