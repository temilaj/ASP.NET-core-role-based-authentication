
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_core_role_based_authentication.Controllers
{
	// [Authorize(Roles="Admin")]
	[Authorize(Policy = "RequireAdminRole")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}