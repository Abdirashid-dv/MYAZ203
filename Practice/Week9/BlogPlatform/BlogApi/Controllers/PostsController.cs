using BlogEntities.Models;
using BlogRepositories.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers;

[ApiController]
[Route("api/posts")]

public class PostsController : ControllerBase
{
    [HttpPost]
    public void AddPost([FromBody] Posts post)
    {
        PostsRepository.AddPost(post);
    }

    [HttpPost("{id:int}")]
    public void AddComment([FromRoute] int postId, [FromBody] Comments comment)
    {
        PostsRepository.AddComment(postId, comment);
    }

    [HttpGet]

    public IActionResult GetAllPosts()
    {
        return Ok(PostsRepository.GetAllPosts());
    }

    [HttpGet("{id:int}")]
    public List<Posts> GetAllPostsByAuthor([FromRoute] int userId)
    {
        return PostsRepository.GetAllPostsByAuthor(userId);
    }

    [HttpGet("{postId:int}&{userId:int}")]
    public Posts GetOnePostByAuthor([FromRoute] int postId, [FromRoute] int userId)
    {
        return PostsRepository.GetOnePostByAuthor(postId, userId);
    }

}