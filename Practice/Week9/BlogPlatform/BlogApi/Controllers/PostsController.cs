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

    [HttpPut("id")]
    public void AddComment([FromRoute] int postId, [FromBody] Comments comment)
    {
        PostsRepository.AddComment(postId, comment);
    }

    [HttpGet]

    public IActionResult GetAllPosts()
    {
        return Ok(PostsRepository.GetAllPosts());
    }

    [HttpGet("id")]
    public List<Posts> GetAllPostsByAuthor([FromRoute] int userId)
    {
        return PostsRepository.GetAllPostsByAuthor(userId);
    }

    [HttpGet("{postId}/{userId}")]
    public Posts GetOnePostByAuthor([FromRoute] int postId, [FromRoute] int userId)
    {
        return PostsRepository.GetOnePostByAuthor(postId, userId);
    }

}