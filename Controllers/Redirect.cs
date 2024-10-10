using Microsoft.AspNetCore.Mvc;

namespace WebProjectForGithubAndBlogSite.Controllers
{
    public class Redirect : Controller
    {
        public IActionResult RedirectYoutube()
        {
            return Redirect("https://www.youtube.com/@KARWALOR");
        }

        public IActionResult RedirectLinkedIn()
        {
            return Redirect("https://www.linkedin.com/in/yi%C4%9Fit-%C3%A7akmakc%C4%B1/");
        }

        public IActionResult RedirectGithub()
        {
            return Redirect("https://github.com/yigitcakmakci");
        }

        public IActionResult RedirectInstagram()
        {
            return Redirect("https://www.instagram.com/yigit_cakmakci99/");
        }
    }
}
