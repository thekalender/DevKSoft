using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevKSoft.Northwind.Business.Abstract;
using DevKSoft.Northwind.Business.Concrete.Manager;
using DevKSoft.Northwind.DataAccess.Abstract;
using DevKSoft.Northwind.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace DevKSoft.Northwind.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>();

        }
    }
}
