﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevKSoft.Northwind.Entities.Concrete;

namespace DevKSoft.Northwind.DataAccess.Concrete.EntityFramework
{
   public class NorthwindContext:DbContext
    {
        public NorthwindContext()
        {
            Database.SetInitializer<NorthwindContext>(null);
        }

        public DbSet<Product> Products { get; set; }
    }
}