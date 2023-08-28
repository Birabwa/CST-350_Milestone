using Microsoft.AspNetCore.Mvc;
using CST_350_Milestone.Services;

using CST_350_Milestone.Models;

namespace CST_350_Milestone.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(RegisterModel user)
        {
            SecurityService security = new SecurityService();
            if (security.IsValid(user))
                return View("LoginSuccess", user);
            else
                return View("LoginFailure", user);
        }
    }
}
