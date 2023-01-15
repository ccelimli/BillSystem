using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class BillValidator : AbstractValidator<Bill>
    {
        public BillValidator()
        {
            RuleFor(bill => bill.CategoryId).NotEmpty().WithMessage("Kategori bilgileri boş olamaz.");
            RuleFor(bill => bill.UserId).NotEmpty().WithMessage("Kullanıcı bilgileri boş olamaz."); 
            RuleFor(bill => bill.CityId).NotEmpty().WithMessage("Şehir bilgileri boş olamaz."); 
            RuleFor(bill => bill.InstitutionId).NotEmpty().WithMessage("Kurum bilgileri boş olamaz.");
            RuleFor(bill => bill.ContractNo).NotEmpty().WithMessage("Sözleşme numarası boş olamaz.");
            RuleFor(bill => bill.InvoiceValue).NotEmpty().WithMessage("Fatura kesim tarihi boş olamaz.");
            RuleFor(bill => bill.DateOfLastPayment).NotEmpty().WithMessage("Son ödeme tarihi boş olamaz.");
            RuleFor(bill => bill.InvoiceValue).NotEmpty().WithMessage("Fatura fiyatı boş olamaz.");
        }
    }
}
