using System.ComponentModel.DataAnnotations;
using static Forum.Common.EntityValidation.Post;

namespace Forum.Data
{
    public class Post
    {
        public Post()
        {
            this.Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MinLength(TittleMinLength)]
        [MaxLength(TittleMaxLength)]
        public string Tittle { get; set; } = null!;
        [Required]
        [MinLength(ContentMinLength)]
        [MaxLength(ContentMaxLength)]
        public string Content { get; set; } = null!;
    }
}
