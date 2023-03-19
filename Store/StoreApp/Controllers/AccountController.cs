using Microsoft.AspNetCore.Mvc;

namespace StoreApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}