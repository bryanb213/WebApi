using Microsoft.EntityFrameworkCore;
using NetApi.Models;

namespace NetApi.Data
{
    public class DataContext : DbContext
    {
    public DataContext(DbContextOptions<DataContext> opt) : base(opt) { }

    public DbSet<Command> Commands { get; set; }

    }
}