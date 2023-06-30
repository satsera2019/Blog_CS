using Microsoft.AspNetCore.Mvc;

namespace Blog.web.Controllers
{
    public class AdminTagsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
