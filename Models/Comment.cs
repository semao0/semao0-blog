using System.ComponentModel.DataAnnotations;

namespace semao0_blog.Models;
public class Comment
{
    [Key]
    public int ComId {get; set;}

    [Required]
    public required string ComContent {get; set;}

    public DateTime ComCreatedDate {set; get; } = DateTime.UtcNow;

    public required int UserId {get; set;}
    public required User User {get; set;}
    
    public required int PostId {get; set;}
    public required Post Post {get; set; }

    public ICollection<Reaction> Reactions {get; set; } = new List<Reaction>();
    public ICollection<PostImg> PostImgs {get; set; } = new List<PostImg>();
}