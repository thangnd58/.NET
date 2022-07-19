using Microsoft.AspNetCore.Mvc;

namespace BookStory.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Message()
        {
            return View();
        }
    }
}
