﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevKSoft.Core.DataAccess;
using DevKSoft.Northwind.Entities.Concrete;

namespace DevKSoft.Northwind.DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
    }
}
