using System;
using DevKSoft.Northwind.DataAccess.Concrete.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevKSoft.DataAccess.Tests
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Gel_all_returns_all_products()
        {
            EfProductDal productDal=new EfProductDal();

            var result = productDal.GelList();
            Assert.AreEqual(80,result.Count);
        }

        [TestMethod]
        public void Gel_all_parameter_returns_filtered_products()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GelList(p=>p.ProductName.Contains("ab"));
            Assert.AreEqual(4, result.Count);
        }
    }
}
