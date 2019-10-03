using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevKSoft.Northwind.Business.ValidtionRules.FluentValidation;
using DevKSoft.Northwind.Entities.Concrete;
using FluentValidation;
using Ninject.Modules;

namespace DevKSoft.Northwind.Business.DependencyResolvers.Ninject
{
   public class ValidationModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Product>>().To<ProductValidator>().InSingletonScope();
        }
    }
}
