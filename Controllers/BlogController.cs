using Microsoft.AspNetCore.Mvc;
using WebProjectForGithubAndBlogSite.Collections;
using WebProjectForGithubAndBlogSite.Collections.Interface;
using WebProjectForGithubAndBlogSite.Models;

namespace WebProjectForGithubAndBlogSite.Controllers
{
    public class BlogController : Controller
    {
      
        public IActionResult Index()
        {
            IBlogClass blogClass = new BlogClass();
            List<BlogContentDataModel> deneme = blogClass.GetContentDataModel();
            //BlogContentDataModel denemeTest = new BlogContentDataModel() 
            //{ Id = 1, Content = "Deneme" , Description = "denemeDesc" , Image = "DenemeImg", Title = "DenemeTitle" };
            return View(deneme);
        }

        public IActionResult Contain(int Id) 
        {
            IBlogClass blogClass = new BlogClass();
            BlogContentDataModel blogContentDataModel = blogClass.GetContentById(Id);
            return View(blogContentDataModel);
        }
    }
}
