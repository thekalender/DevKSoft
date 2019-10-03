using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevKSoft.Northwind.Entities.Concrete;

namespace DevKSoft.Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetList();
        Product GetById(int id);
        Product Add(Product product);
        void TransactionalOpetaion(Product product1, Product product2);
    }
}
