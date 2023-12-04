using BlogEntities.Models;

namespace BlogRepositories.Repositories;

public static class PostsRepository
{
    private static List<Posts> posts { get; set; }

    static PostsRepository()
    {
        posts = new List<Posts>();
    }

    public static void AddPost(Posts post)
    {
        if (post.Equals(null))
            return;
        posts.Add(post);
    }

    public static void AddComment(int postId, Comments comment)
    {
        var post = posts.Where(pId => pId.PostId.Equals(postId)).SingleOrDefault();
        if (post is not null)
            posts[post.PostId].CommentList.Add(comment);
    }

    public static List<Posts> GetAllPosts()
    {
        return posts;
    }

    public static List<Posts> GetAllPostsByAuthor(int userId)
    {
        return posts.Where(author => author.Author.UserId.Equals(userId)).ToList();
    }


    public static Posts GetOnePostByAuthor(int postId, int userId)
    {
        var post = posts.SingleOrDefault(pt => pt.PostId == postId && pt.Author.UserId == userId);

        if (post is not null)
            return post;
        else
            throw new Exception(nameof(post));
    }

}