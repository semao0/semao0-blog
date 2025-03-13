using System.ComponentModel.DataAnnotations;

namespace semao0_blog.Models;
public class PostImg
{
    [Key]
    public int PostImgId {get; set;}

    [Required]
    public required string ImgUrl {get; set; }

    public DateTime  ImgDate {get; set;} = DateTime.UtcNow;

    public Post? Post {get; set; }
    public int? PostId {get;set;}

    public Comment? Comment {get; set; }
    public int? ComId {get; set;}
}