using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevKSoft.Northwind.Entities.ComplexTypes;
using DevKSoft.Northwind.Entities.Concrete;

namespace DevKSoft.Northwind.Business.Abstract
{
    public interface IUserService
    {
        User GetByUserNameAndPassword(string userName, string password);

        List<UserRoleItem> GetUserRoles(User user);
    }
}
