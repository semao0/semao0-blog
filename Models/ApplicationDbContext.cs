using Microsoft.EntityFrameworkCore;

namespace semao0_blog.Models;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }
    
    public DbSet<Comment> Comments {get; set;}
    public DbSet<Emoji> Emojis {get; set;}
    public DbSet<Post> Posts {get; set;}
    public DbSet<PostImg> PostImgs {get; set;}
    public DbSet<Reaction> Reactions {get; set;}
    public DbSet<Role> Roles {get; set;}
    public DbSet<User> Users {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
        .HasMany(u => u.Posts)
        .WithOne(p => p.User)
        .HasForeignKey(p => p.UserId)
        .OnDelete(DeleteBehavior.SetNull);

         modelBuilder.Entity<User>()
        .HasMany(u => u.Reactions)
        .WithOne(r => r.User)
        .HasForeignKey(r => r.UserId)
        .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<User>()
        .HasMany(u => u.Comments)
        .WithOne(c => c.User)
        .HasForeignKey(c => c.UserId)
        .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<User>()
        .HasIndex(u => u.UserEmail)
        .IsUnique();

        modelBuilder.Entity<Post>()
        .HasMany(p => p.Comments)
        .WithOne(c => c.Post)
        .HasForeignKey(c => c.PostId)
        .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Post>()
        .HasMany(p => p.Reactions)
        .WithOne(r => r.Post)
        .HasForeignKey(r => r.PostId)
        .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Post>()
        .HasMany(p => p.PostImgs)
        .WithOne(p => p.Post)
        .HasForeignKey(p => p.PostId)
        .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Comment>()
        .HasMany(c => c.Reactions)
        .WithOne(r => r.Comment)
        .HasForeignKey(r => r.ComId)
        .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Comment>()
        .HasMany(c => c.PostImgs)
        .WithOne(p => p.Comment)
        .HasForeignKey(p => p.ComId)
        .OnDelete(DeleteBehavior.Cascade);

         modelBuilder.Entity<Emoji>()
        .HasMany(e => e.Reactions)
        .WithOne(r => r.Emoji)
        .HasForeignKey(r => r.EmojiId)
        .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<Role>()
        .HasMany(r => r.Users)
        .WithOne(u => u.Role)
        .HasForeignKey(u => u.RoleId)
        .OnDelete(DeleteBehavior.SetNull);
    }
}
