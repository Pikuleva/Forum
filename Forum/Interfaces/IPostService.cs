

using Forum.Web.ViewModels.Post;

namespace Forum.Services.Interfaces
{
    public interface IPostService
    {
        Task<IEnumerable<PostListViewModel>> ListAllAsync();

        Task AddPostAsync(PostFormModul postViewModel);

        Task<PostFormModul> GetForEditByIdAsync(string id);

        Task EditByIdAsync(string id,PostFormModul postEditedModel);
    }
}
