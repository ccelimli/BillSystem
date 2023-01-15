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
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            //FirstName
            RuleFor(user => user.FirstName).NotEmpty().WithMessage("Kullanıcı ismi boş olamaz!");
            RuleFor(user => user.FirstName).Must(ControlName).WithMessage("Geçersiz kullanıcı ismi!");
            RuleFor(user => user.FirstName).MinimumLength(2).WithMessage("Kullanıcı ismi 2 karakterden daha az olamaz!");

            // LastName
            RuleFor(user => user.LastName).NotEmpty().WithMessage("Kullanıcı soyismi boş olamaz!");
            RuleFor(user => user.LastName).Must(ControlName).WithMessage("Geçersiz kullanıcı soyismi!");
            RuleFor(user => user.LastName).MinimumLength(2).WithMessage("Kullanıcı soyismi en az 2 karakter olmalıdır!");

            //NationalityNo
            RuleFor(user => user.NationalityNo).NotEmpty().WithMessage("T.C. kimlik numarası boş olamaz!");
            RuleFor(user => user.NationalityNo).Must(ControlNationalityNumber).WithMessage("Geçersiz T.C. kimlik numarası!");

            //Birthday
            RuleFor(user => user.Birthday).NotEmpty().WithMessage("Doğum tarihi boş olamaz!");
            RuleFor(user => user.Birthday).Must(ControlBirthday).WithMessage("Geçersiz doğum tarihi!");

            //Address
            RuleFor(user => user.Address).NotEmpty().WithMessage("Adres boş olamaz!");

            //PhoneNumber
            RuleFor(user => user.PhoneNumber).NotEmpty().WithMessage("Telefon numarası boş olamaz!");
            RuleFor(user => user.PhoneNumber).Must(ControlPhoneNumber).WithMessage("Geçersiz telefon numarası!");
            RuleFor(user => user.PhoneNumber).Must(StartWith).WithMessage("Telefon numarası 0(sıfır) ile başlayamaz!");

            //Email
            RuleFor(user => user.Email).NotEmpty().WithMessage("Kullanıcı e-postası boş olamaz!");
            RuleFor(user => user.Email).Must(ControlEmail).WithMessage("Geçersiz e-posta!");
        }

        //Control Name
        private bool ControlName(string arg)
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

        //Control Email
        private bool ControlEmail(string arg)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
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

        //NationalityNo
        private bool ControlNationalityNumber(string arg)
        {
            Regex regex = new Regex(@"^1-9]{1}[0-9]{10}$");
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

        // ControlPhoneNumber
        private bool ControlPhoneNumber(string arg)
        {
            Regex regex = new Regex(@"^[1-9]{10}$");
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

        //Birthday
        private bool ControlBirthday(DateTime arg)
        {
            Regex regex = new Regex(@"^([012]\d|30|31)/(0\d|10|11|12)/\d{4}$");
            var result = regex.Match(Convert.ToString(arg));
            if (result.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool StartWith(string arg)
        {
            var result = arg.StartsWith('0');
            if (arg.StartsWith('0'))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
