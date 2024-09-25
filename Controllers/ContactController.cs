using Microsoft.AspNetCore.Mvc;

namespace WebProjectForGithubAndBlogSite.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
