using Microsoft.AspNetCore.Mvc;

namespace DDD.Contact.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
