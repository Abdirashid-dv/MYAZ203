namespace BlogEntities.Models;

public class Posts
{
    public int PostId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime DatePosted { get; set; }
    public Users Author { get; set; }
    public List<Comments> CommentList { get; set; }

}