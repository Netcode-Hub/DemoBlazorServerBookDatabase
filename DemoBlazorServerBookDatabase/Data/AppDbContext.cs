using DemoBlazorServerBookDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoBlazorServerBookDatabase.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Book> BooksTable { get; set; } = default!;
    }
}
