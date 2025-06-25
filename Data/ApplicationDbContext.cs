using FraudDetectionSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace FraudDetectionSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ClaimModel> Claims { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
