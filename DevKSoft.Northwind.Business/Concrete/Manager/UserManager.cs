using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevKSoft.Northwind.Business.Abstract;
using DevKSoft.Northwind.DataAccess.Abstract;
using DevKSoft.Northwind.Entities.ComplexTypes;
using DevKSoft.Northwind.Entities.Concrete;

namespace DevKSoft.Northwind.Business.Concrete.Manager
{
    public class UserManager:IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public User GetByUserNameAndPassword(string userName, string password)
        {
            return _userDal.Get(u => u.Username == userName && u.Password == password);
        }

        public List<UserRoleItem> GetUserRoles(User user)
        {
            return _userDal.GetUserRoles(user);
        }
    }
}
