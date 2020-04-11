using ClubSite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
        private readonly IConfiguration configuration;

        public Context (IConfiguration configuration) : base()
        {
            this.configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Better to not have the connection string in here optionsBuilder.UseMySQL(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
                optionsBuilder.UseMySQL(configuration["ConnectionString"]);
            }
        }
    }
}
