using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using WebApi_Common.Models;

namespace WebApi_Server.Repositories;

public class JobContext : DbContext
{
   
    public DbSet<Job> Jobs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Database=ServerDb;Integrated Security=True;");
    }
}