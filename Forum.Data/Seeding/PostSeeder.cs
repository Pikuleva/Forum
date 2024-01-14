namespace Forum.Data
{
     class PostSeeder
    {
        internal Post[] GeneratePosts()
        {
            ICollection<Post> posts = new HashSet<Post>();
            Post currentPost;

            currentPost = new Post()
            {
                Tittle = "My first post",
                Content = "Hi from my first comment in this application! It's work!"

            };
            posts.Add(currentPost);

            currentPost = new Post()
            {
                Tittle = "My second post",
                Content = "Hi again from my first comment in this application! It's work!"
            };

            posts.Add(currentPost);

            

            currentPost = new Post()
            {
                Tittle = "My third post",
                Content = "Hi again and again from my first comment in this application! It's work!"
            };
            posts.Add(currentPost);

            return posts.ToArray();
        }
    }
}
