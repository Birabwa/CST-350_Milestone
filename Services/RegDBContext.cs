using CST_350_Milestone.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CST_350_Milestone.Services
{
    public class RegDBContext : DbContext
    {
        public RegDBContext(DbContextOptions<RegDBContext> options) : base(options)
        {
        }

        public DbSet<RegisterModel> Register { get; set; }
    }
}
