using CST_350_Milestone.Models;
using CST_350_Milestone;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace CST_350_Milestone.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ShowRegistrationDetails(RegisterModel model)
        {
            if (ModelState.IsValid) // Check if submitted data is valid
            {
                return View(model); 
            }
            return View("Index", model);
        }
    }
}
