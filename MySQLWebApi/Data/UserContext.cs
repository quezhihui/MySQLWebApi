using Microsoft.EntityFrameworkCore;
using MySQLWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MySQLWebApi.Data
{
    public class UserContext:DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder bulider)
        {
            
            base.OnModelCreating(bulider);

            bulider.Entity<User>().ToTable("Users").HasKey(u => u.Id);
        }

        public DbSet<User> Users { get; set; }
    }
}
