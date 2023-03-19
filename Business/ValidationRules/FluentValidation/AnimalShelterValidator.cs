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
    public class AnimalShelterValidator : AbstractValidator<AnimalShelter>
    {
        public AnimalShelterValidator()
        {
            RuleFor(animalShelter=>animalShelter.Name).NotEmpty().WithMessage("Barınak ismi boş olamaz!");
            RuleFor(animalShelter => animalShelter.Name).Must(ControlAnimalShelterName).WithMessage("Geçersiz barınak ismi!");
            RuleFor(animalShelter=>animalShelter.Iban).NotEmpty().WithMessage("IBAN numarası boş olamaz!");
            RuleFor(animalShelter=>animalShelter.BankId).NotEmpty().WithMessage("Banka bilgileri boş olamaz!");
            RuleFor(animalShelter=>animalShelter.PlatformId).NotEmpty().WithMessage("Platform bilgileri boş olamaz!");
        }

        //ControlName
        private bool ControlAnimalShelterName(string arg)
        {
            Regex regex = new Regex(@"^[A-ZİĞÜŞÖÇ][a-zA-Z0-9ğüşöçıİĞÜŞÖÇ]*$");
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
