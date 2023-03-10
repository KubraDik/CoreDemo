using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName)
                .NotEmpty()
                .WithMessage("Yazar adı soyadı kısmı boş geçilemez.");

            RuleFor(x => x.WriterMail)
                .NotEmpty()
                .WithMessage("Mail adresi boş geçilemez.")
                .Matches(@"[@,.]+")
                .WithMessage("Mail adresinde @ işareti ve en az bir noktalama işareti bulunmalıdır. ");
            RuleFor(x => x.WriterPassword)
                .NotEmpty()
                .WithMessage("Şifre boş geçilemez.")
                .Matches(@"[A-Z]+")
                .WithMessage("Sifre en az bir büyük harften ibaret olmalıdır.")
                .Matches(@"[a-z]+")
                .WithMessage("Sifre en az bir küçük harften ibaret olmalıdır.")
                .Matches(@"[0-9]+")
                .WithMessage("Sifre en az bir rakamdan ibaret olmalıdır.");
            RuleFor(x => x.WriterName)
                .MinimumLength(2)
                .WithMessage("Lütfen en az 2 karakter girişi yapalım")
                .MaximumLength(50)
                .WithMessage("Lütfen en fazla 50 karakter girişi yapalım.");

            
        }
    }
}
