using LoveFinderz.Models;
using Microsoft.EntityFrameworkCore;

namespace LoveFinderz.Storing
{
    public class LoveFinderzContext : DbContext
    {
        public DbSet<Lover> Lovers { get; set; }

        
        public LoveFinderzContext(){}

        public LoveFinderzContext(DbContextOptions<LoveFinderzContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=tcp:flutter.database.windows.net,1433;Initial Catalog=LoveFinderz;Persist Security Info=False;User ID=sqladmin;Password=pass123!");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //build entities here
            builder.Entity<Lover>().HasKey(lover => lover.UserName);
        }
    }
}
