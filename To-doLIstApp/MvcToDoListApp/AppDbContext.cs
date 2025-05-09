using MvcToDoListApp.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-OB4MJRP\\SQL2022;Database=ToDoListApp;User Id=sa;Password=84846633664848;TrustServerCertificate=True;");
    }

    public DbSet<User> Users { get; set; }
    public DbSet<ToDoTask> ToDoTasks { get; set; }

}
