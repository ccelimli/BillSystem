using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class BillDetailPrivateDto : IDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string CityName { get; set; }
        public string UserNationalityId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string InstitutionName { get; set; }
        public string ContractNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DateOfLastPayment { get; set; }
        public decimal InvoiceValue { get; set; }
        public bool Status { get; set; }
    }
}
