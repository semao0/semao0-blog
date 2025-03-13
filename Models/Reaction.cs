using System.ComponentModel.DataAnnotations;

namespace semao0_blog.Models;
public class Reaction
{
    [Key]
    public int ReactId {get; set;}

    public Post? Post {get; set;}
    public int? PostId {get; set;}

    public Comment? Comment {get; set;}
    public int? ComId {get; set;}

    public required User User {get; set;}
    public required int UserId {get; set;}

    public required Emoji Emoji {get; set;}
    public required int EmojiId {get; set;}
}