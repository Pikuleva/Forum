﻿using Forum.Data;
using Forum.Services.Interfaces;
using Forum.Web.ViewModels.Post;
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
    }
}
