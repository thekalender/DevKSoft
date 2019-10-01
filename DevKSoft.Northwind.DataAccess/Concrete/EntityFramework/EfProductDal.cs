using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevKSoft.Core.DataAccess.EntityFramework;
using DevKSoft.Northwind.DataAccess.Abstract;
using DevKSoft.Northwind.Entities.Concrete;

namespace DevKSoft.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
    }
}
