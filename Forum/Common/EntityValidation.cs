namespace Forum.Common
{
    public static class EntityValidation
    {
        public static class Post
        {
            public const int TittleMinLength = 10;
            public const int TittleMaxLength = 50;
            public const int ContentMinLength = 30;
            public const int ContentMaxLength = 1500;
        }
    }
}
