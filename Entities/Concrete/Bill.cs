using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Bill : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public int CityId { get; set; }
        public int InstitutionId { get; set; }
        public string ContractNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DateOfLastPayment { get; set; }
        public decimal InvoiceValue { get; set; }
        public bool Status { get; set; }
    }
}
