using Microsoft.AspNetCore.Mvc;

namespace WebProjectForGithubAndBlogSite.Controllers
{
    public class PortofolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}