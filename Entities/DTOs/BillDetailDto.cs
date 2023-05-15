using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class BillDetailDto : IDto
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int CityId { get; set; }
        public int InstitutionId { get; set; }
        public string CategoryName { get; set; }
        public string CityName { get; set; }
        public string InstitutionName { get; set; }
        public string ContractNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DateOfLastPayment { get; set; }
        public decimal InvoiceValue { get; set; }

        public string Website { get; set; }
        public bool Status { get; set; }
    }
}
