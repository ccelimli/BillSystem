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
    public class FoundationValidator : AbstractValidator<Foundation>
    {
        public FoundationValidator()
        {
            RuleFor(foundation => foundation.Iban).NotEmpty().WithMessage("Yardım kuruluşu IBAN bilgileri boş olamaz!");
            RuleFor(foundation => foundation.Name).NotEmpty().WithMessage("Yardım kuruluşu isim bilgileri boş olamaz!");
            RuleFor(foundation => foundation.Name).Must(ControlFoundationName).WithMessage("Geçersiz yardım kuruluşu ismi!");
            RuleFor(foundation => foundation.PlatformId).NotEmpty().WithMessage("Yardım kuruluşu platform bilgileri boş olamaz!");
            RuleFor(foundation => foundation.BankId).NotEmpty().WithMessage("Yardım kuruluşu banka bilgieri boş olamaz!");
        }

        //Control Name
        private bool ControlFoundationName(string arg)
        {
            Regex regex = new Regex(@"^[A-ZİĞÜŞÖÇ][a-zA-ZğüşöçıİĞÜŞÖÇ]*$");
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
