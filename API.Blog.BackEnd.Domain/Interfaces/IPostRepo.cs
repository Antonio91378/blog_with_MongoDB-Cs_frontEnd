﻿using API.Blog.BackEnd.Domain.Entities;


namespace API.Blog.BackEnd.Domain.Interfaces
{
    public interface IPostRepo
    {
        Task CreatePostAsync(Post post);
        Task<List<Post>> DisplayAllPostsAsync();
        Task<Post> DisplayPostByIdAsync(string id);
        Task DeletePostByIdAsync(string id);
    }
}