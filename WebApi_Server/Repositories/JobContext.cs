using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using WebApi_Server.Models;

namespace WebApi_Server.Repositories;

public class JobContext : DbContext
{
    public JobContext([NotNull] DbContextOptions options) : base(options)
    {
        
    }
    
    public DbSet<Job> Jobs { get; set; }
}