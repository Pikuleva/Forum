﻿using System.ComponentModel.DataAnnotations;
using static Forum.Common.EntityValidation.Post;

namespace Forum.Web.ViewModels.Post
{

    public class PostFormModul
    {
        [Required]
        [StringLength(TittleMaxLength, MinimumLength = TittleMinLength)]
        public string Title { get; set; } = null!;
        [Required]
        [StringLength(ContentMaxLength,MinimumLength =ContentMinLength)]
        public string Content { get; set; } = null!;
    }
}
