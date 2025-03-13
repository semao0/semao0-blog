using System.ComponentModel.DataAnnotations;

namespace semao0_blog.Models;
public class Emoji
{
    [Key]
    public int EmojiId {get; set;}

    [Required]
    public required string EmojiName {get; set;}

    public string? EmojiCode {get; set;}

    public string? EmojiUrl{get; set;}

    public ICollection<Reaction> Reactions {get; set;} = new List<Reaction>();

}