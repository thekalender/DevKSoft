using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevKSoft.Core.CrossCuttingConcerns.Security.Web;
using DevKSoft.Northwind.Business.Abstract;

namespace DevKSoft.Northwind.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        public string Login(string userName, string password)
        {
            var user = _userService.GetByUserNameAndPassword(userName, password);

            if (user != null)
            {
                AuthenticationHelper.CreateAuthCookie(
                    new Guid(), user.Username,
                    user.Email,
                    DateTime.Now.AddDays(15),
                    _userService.GetUserRoles(user).Select(u=>u.RoleName).ToArray(),
                    false,
                    user.FirstName,
                    user.LastName);
                return "User is authentication";
            } ;

            return "User is Not Authendicated !";
            }
        
    }
}