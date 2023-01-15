using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class BankValidator : AbstractValidator<Bank>
    {
        public BankValidator()
        {
            RuleFor(bank => bank.Name).NotEmpty().WithMessage("Banka ismi boş lamaz!");
            RuleFor(bank => bank.Name).Must(ControlBankName).WithMessage("Geçersiz banka ismi!");
        }

        //Control Name
        private bool ControlBankName(string arg)
        {
            Regex regex = new Regex(@"^[A-Z0-9İĞÜŞÖÇ][a-zA-Z0-9ğüşöçıİĞÜŞÖÇ]*$");
            var result = regex.Match(arg);
            if (result.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
