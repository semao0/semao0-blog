using System.ComponentModel.DataAnnotations;

namespace semao0_blog.Models;
public class User
{
    [Key]
    public int UserId {get; set; }

    [Required]
    [EmailAddress]
    public required string UserEmail {get; set; }

    [Required]
    public required string UserPasswordHash {get; set; }

    public required string UserName {get; set; }
    public string? UserAvatar {get; set; }
    public bool UserEmailConf {get; set; }

    public required int RoleId {get; set; }
    public required Role Role {get; set; }

    public ICollection<Post> Posts {get; set; } = new List<Post>();
    public ICollection<Comment> Comments {get; set; } = new List<Comment>();
    public ICollection<Reaction> Reactions {get; set; } = new List<Reaction>();
}