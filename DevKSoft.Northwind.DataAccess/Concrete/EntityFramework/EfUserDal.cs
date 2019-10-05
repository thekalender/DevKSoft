using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevKSoft.Core.DataAccess.EntityFramework;
using DevKSoft.Northwind.DataAccess.Abstract;
using DevKSoft.Northwind.Entities.ComplexTypes;
using DevKSoft.Northwind.Entities.Concrete;

namespace DevKSoft.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal:EfEntityRepositoryBase<User,NorthwindContext>,IUserDal
    {
        public List<UserRoleItem> GetUserRoles(User user)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var result = from ur in context.UserRoles
                    join r in context.Roles on ur.UserId equals r.Id
                    where ur.UserId == r.Id
                    select new UserRoleItem {RoleName = r.Name};
                return result.ToList();
            }
        }
    }
}
