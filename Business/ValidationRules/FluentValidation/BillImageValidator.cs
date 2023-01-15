using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class BillImageValidator : AbstractValidator<BillImage>
    {
        public BillImageValidator()
        {
            RuleFor(billImage => billImage.BillId).NotEmpty().WithMessage("Fatura bilgileri boş olamaz!");
            RuleFor(billImage => billImage.ImagePath).NotEmpty().WithMessage("Dosya yolu boş olamaz!");            
        }
    }
}
