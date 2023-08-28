using Microsoft.AspNetCore.Mvc;
using Milestone1.
namespace Milestone1.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly RegDBContext _context;

        public RegistrationController(RegDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ShowRegistrationDetails(RegisterModel model)
        {
            if (ModelState.IsValid) // Check if submitted data is valid
            {
                _context.Registers.Add(model); // Make sure it's 'Registers' and not 'Register'
                _context.SaveChanges();

                return View(model);
            }
            return View("Index", model);
        }
    }
}
