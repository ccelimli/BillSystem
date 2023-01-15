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
    public class BillDal : EntityRepositoryBase<Bill, BillSystemContext>, IBillDal
    {
        public List<BillDetailPrivateDto> GetBillDetailPrivate()
        {
            using (BillSystemContext context = new BillSystemContext())
            {
                var GetBillDetailPrivate = from bill in context.Bills
                                           join category in context.Categories
                                           on bill.CategoryId equals category.Id
                                           join user in context.Users
                                           on bill.UserId equals user.Id
                                           join city in context.Cities
                                           on bill.CityId equals city.Id
                                           join institution in context.Institutions
                                           on bill.InstitutionId equals institution.Id
                                           select new BillDetailPrivateDto
                                           {
                                               Id = bill.Id,
                                               CategoryName = category.Name,
                                               CityName = city.Name,
                                               UserNationalityId = user.NationalityNo,
                                               UserFirstName = user.FirstName,
                                               UserLastName = user.LastName,
                                               Address = user.Address,
                                               PhoneNumber = user.PhoneNumber,
                                               Email = user.Email,
                                               InstitutionName = institution.Name,
                                               ContractNo = bill.ContractNo,
                                               InvoiceDate = bill.InvoiceDate,
                                               DateOfLastPayment = bill.DateOfLastPayment,
                                               InvoiceValue = bill.InvoiceValue,
                                               Status = bill.Status
                                           };
                return GetBillDetailPrivate.ToList();
            }
        }

        public List<BillDetailDto> GetBillDetails()
        {
            using (BillSystemContext context = new BillSystemContext())
            {
                var GetBillDetail = from bill in context.Bills
                                    join category in context.Categories
                                    on bill.CategoryId equals category.Id
                                    join city in context.Cities
                                    on bill.CityId equals city.Id
                                    join institution in context.Institutions
                                    on bill.InstitutionId equals institution.Id
                                    select new BillDetailDto
                                    {
                                        Id = bill.Id,
                                        CategoryName = category.Name,
                                        CityName = city.Name,
                                        InstitutionName = institution.Name,
                                        ContractNo = bill.ContractNo,
                                        InvoiceDate = bill.InvoiceDate,
                                        DateOfLastPayment = bill.InvoiceDate,
                                        InvoiceValue = bill.InvoiceValue,
                                        Status = bill.Status,
                                    };
                return GetBillDetail.ToList();
            }
        }
    }
}
