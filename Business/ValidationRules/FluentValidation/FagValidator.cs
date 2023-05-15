using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class FagValidator : AbstractValidator<Faq>
    {
        public FagValidator()
        {
            RuleFor(fag=>fag.Question).NotEmpty().WithMessage("SSS soru kısmı boş olamaz!");
            RuleFor(fag => fag.Answer).NotEmpty().WithMessage("SSS cevap kısmı boş olamaz!");
        }
    }
}
