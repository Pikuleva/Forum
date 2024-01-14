using System.ComponentModel.DataAnnotations;


namespace Forum.Web.ViewModels.Post
{

    public class PostFormModul
    {
        [Required]
        
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
    }
}
