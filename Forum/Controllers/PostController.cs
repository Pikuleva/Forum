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

        [HttpPost]
        public async Task<IActionResult> Add(PostFormModul post)
        {
            if (!ModelState.IsValid)
            {
                return View(post);
            }
            try
            {
                await this.postService.AddPostAsync(post);
            }
            catch (Exception)
            {

                ModelState.AddModelError(string.Empty, "Unexpected error occured while adding your post!");
                return View(post);
            }
            return RedirectToAction("All");
        }

        public async Task<IActionResult> Edit(string id)
        {
            try
            {
                PostFormModul postModel = await this.postService.GetForEditByIdAsync(id);
                return View(postModel);

            }
            catch (Exception)
            {
                return RedirectToAction("All");
            } 
        }
        [HttpPost]
        public async Task<IActionResult> Edit(string id,PostFormModul postModel)
        {
            if (!ModelState.IsValid)
            {
                return this.View(postModel);
            }
            try
            {
                await this.postService.EditByIdAsync(id, postModel);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Unexpected error occured while adding your post!");
                return View(postModel);
            }
            return RedirectToAction("All");
        }
   
    }
}
