using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevKSoft.Northwind.Entities.Concrete;
using FluentValidation;

namespace DevKSoft.Northwind.Business.ValidtionRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("Kategori boş geçilemez !");
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün adı boş geçilemez");
            RuleFor(p => p.QuantityPerUnit).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("Fiyat boş geçilemez");
            RuleFor(p => p.ProductName).Length(2, 20);
            RuleFor(p => p.UnitPrice).GreaterThan(20).When(p => p.CategoryId == 2);
        }
    }
}
