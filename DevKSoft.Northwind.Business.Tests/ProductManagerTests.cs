using System;
using DevKSoft.Northwind.Business.Concrete.Manager;
using DevKSoft.Northwind.DataAccess.Abstract;
using DevKSoft.Northwind.Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentValidation;
using Moq;

namespace DevKSoft.Northwind.Business.Tests
{
    [TestClass]
    public class ProductManagerTests
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Product_validation_check()
        {
            Mock<IProductDal> mock= new Mock<IProductDal>();
            ProductManager productManager=new ProductManager(mock.Object);

            productManager.Add(new Product());
        }
    }
}
