using System.ComponentModel.DataAnnotations;

namespace semao0_blog.Models;
public class Role
{
    [Key]
    public int RoleId {get; set; }

    [Required]
    public required string RoleName {get; set; }
    
    public required string RoleDesc {get; set;}

    public ICollection<User> Users {get; set; } = new List<User>();
}