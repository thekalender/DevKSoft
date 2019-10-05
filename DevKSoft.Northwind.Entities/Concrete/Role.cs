using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using DevKSoft.Core.Entities;

namespace DevKSoft.Northwind.Entities.Concrete
{
    public class Role:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
