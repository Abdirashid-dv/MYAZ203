namespace BlogEntities.Models;

public class Comments
{
    public int CommentId { get; set; }
    public string Content { get; set; } = string.Empty;
    public DateTime DatePosted { get; set; }
    public Users? Author { get; set; }
}