using System.ComponentModel.DataAnnotations;

namespace semao0_blog.Models;
public class Post
{
    [Key]
    public int PostId {get; set; }

    [Required]
    public required string PostTitle {get; set; }

    [Required]
    public required string PostContent {get; set; }

    public DateTime PostDate {get; set; } = DateTime.UtcNow;

    public required int UserId {get;set;}
    public required User User {get;set;}

    public ICollection<PostImg> PostImgs {get; set;} = new List<PostImg>();
    public ICollection<Reaction> Reactions {get;set;} = new List<Reaction>();
    public ICollection<Comment> Comments {get; set; } = new List<Comment>();
}