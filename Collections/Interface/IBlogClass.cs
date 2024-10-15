using Microsoft.AspNetCore.Mvc;
using WebProjectForGithubAndBlogSite.Models;

namespace WebProjectForGithubAndBlogSite.Collections.Interface
{
    public interface IBlogClass
    {
        List<BlogContentDataModel> GetContentDataModel();
        BlogContentDataModel GetContentById(int Id);
    }
}
