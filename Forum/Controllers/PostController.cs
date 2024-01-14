using Forum.Services.Interfaces;
using Forum.Web.ViewModels.Post;
using Microsoft.AspNetCore.Mvc;

namespace Forum.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService postService;
        public PostController(IPostService postService)
        {
            this.postService = postService;
        }
        public async Task<IActionResult> All()
        {
            IEnumerable<PostListViewModel> allPosts = await this.postService.ListAllAsync();
            return View(allPosts);
        }
        public IActionResult Add()
        {
            return View();
        }
    }
}
