﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevKSoft.Core.Aspects.Postsharp;
using DevKSoft.Northwind.Business.Abstract;
using DevKSoft.Northwind.Business.ValidtionRules.FluentValidation;
using DevKSoft.Northwind.DataAccess.Abstract;
using DevKSoft.Northwind.Entities.Concrete;
using FluentValidation.Resources;

namespace DevKSoft.Northwind.Business.Concrete.Manager
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetList()
        {
           return _productDal.GelList();
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductId == id);
        }

        [FluentValidationAspet(typeof(ProductValidator))]
        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }
    }
}
