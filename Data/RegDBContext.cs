using CST_350_Milestone.Models;
using Microsoft.EntityFrameworkCore;

public class RegDBContext : DbContext
{
    public RegDBContext(DbContextOptions<RegDBContext> options) : base(options)
    {
    }

    public DbSet<RegisterModel> Register { get; set; }
}
