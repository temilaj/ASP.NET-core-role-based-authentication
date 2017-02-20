using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    // [Authorize(Roles="Admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            ViewData["PageID"] = "Admin";
            return View();
        }

        public IActionResult Settings()
        {
            ViewData["Message"] = "Just another page restricted to the super admin user ";
            return View();
        }
       
    }
}
