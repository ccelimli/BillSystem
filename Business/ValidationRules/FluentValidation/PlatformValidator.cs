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
    public class PlatformValidator : AbstractValidator<Platform>
    {
        public PlatformValidator()
        {
            RuleFor(platform => platform.Name).NotEmpty().WithMessage("Platform İsmi boş olamaz!");
            RuleFor(platform => platform.Name).Must(ControlPlatformName).WithMessage("Geçersiz Platform İsmi");
        }

        //Control Name
        private bool ControlPlatformName(string arg)
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
