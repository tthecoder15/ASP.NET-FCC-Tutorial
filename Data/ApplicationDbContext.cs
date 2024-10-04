using fcc_tutorial2.Models;
using Microsoft.EntityFrameworkCore;

namespace fcc_tutorial2.Data;

public class ApplicationDbContext :DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
}
