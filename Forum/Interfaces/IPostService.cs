

using Forum.Web.ViewModels.Post;

namespace Forum.Services.Interfaces
{
    public interface IPostService
    {
        Task<IEnumerable<PostListViewModel>> ListAllAsync();

        Task AddPostAsync(PostFormModul postViewModel);

        Task<PostFormModul> GetForEditAndDeleteByIdAsync(string id);

        Task EditByIdAsync(string id,PostFormModul postEditedModel);

        Task DeleteByIdAsync(string id);
    }
}
