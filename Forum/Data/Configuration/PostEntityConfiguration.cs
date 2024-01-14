using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Forum.Data
{
    public class PostEntityConfiguration :IEntityTypeConfiguration<Post>
    {
        private readonly PostSeeder postSeadeer;
        public PostEntityConfiguration()
        {
                this.postSeadeer = new PostSeeder();
        }
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasData(this.postSeadeer.GeneratePosts());
        }
    }
}
