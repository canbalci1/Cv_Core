using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator:AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x=>x.Name)
                .NotNull().WithMessage("Proje adı boş gecilemez.")
                .MinimumLength(5).WithMessage("Proje adı 5 karakterden az olamaz.")
                .MaximumLength(100).WithMessage("Proje adı en fazla 100 karakter olabilir.");
            RuleFor(x => x.ImageUrl).NotNull().WithMessage("Görsel alanı boş geçilemez.");
            RuleFor(x => x.ImageUrl2).NotNull().WithMessage("Görsel2 alanı boş geçilemez.");
            RuleFor(x => x.Price).NotNull().WithMessage("Fiyat alanı boş geçilemez.");
            RuleFor(x => x.Value).NotNull().WithMessage("Değer alanı boş geçilemez.");
            RuleFor(x => x.ProjectUrl).NotNull().WithMessage("Proje alanı boş geçilemez.");



        }
    }
}
