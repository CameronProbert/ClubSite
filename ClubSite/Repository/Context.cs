using ClubSite.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace ClubSite.Repository
{
    public class Context : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<Asset> Assets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
        }
    }
}
