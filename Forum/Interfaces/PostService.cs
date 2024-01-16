using Forum.Data;
using Forum.Services.Interfaces;
using Forum.Web.ViewModels.Post;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Forum.Services
{
    public class PostService : IPostService
    {
        private readonly ForumDbContext dbContext;
        public PostService(ForumDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddPostAsync(PostFormModul postViewModel)
        {
            Post newPost = new Post()
            {
                Tittle=postViewModel.Title,
                Content=postViewModel.Content
            };
            await this.dbContext.Posts.AddAsync(newPost);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task EditByIdAsync(string id, PostFormModul postEditedModel)
        {
            Post postToEdite = await this.dbContext.Posts
                .FirstAsync(p => p.Id.ToString().ToLower() == id.ToLower());

            postToEdite.Tittle = postEditedModel.Title;
            postToEdite .Content = postEditedModel.Content;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<PostFormModul?> GetForEditAndDeleteByIdAsync(string id)
        {
            Post postToEdit = await this.dbContext
                .Posts
               .FirstOrDefaultAsync(p => p.Id.ToString().ToLower() == id.ToLower());

            if (postToEdit == null)
            {
                return null;
            }

            return new PostFormModul()
            {
                Title = postToEdit.Tittle,
                Content = postToEdit.Content
            };
        }

        public async Task<IEnumerable<PostListViewModel>> ListAllAsync()
        {
            IEnumerable<PostListViewModel> allPosts = await dbContext
                .Posts
                .Select(p => new PostListViewModel
                {
                    Id = p.Id.ToString(),
                    Tittle = p.Tittle,
                    Content = p.Content
                })
                .ToArrayAsync();
               
            return allPosts;
        }

      
        public async Task DeleteByIdAsync(string id)
        {
            Post postToDelete = await dbContext
                  .Posts
                  .FirstAsync(p=>p.Id.ToString()==id);

            this.dbContext.Posts.Remove(postToDelete);
            await this.dbContext.SaveChangesAsync();

           
        }
    }
}
