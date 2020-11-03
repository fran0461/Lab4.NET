using Lab4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Data
{
    public class SchoolCommunityContext : DbContext
    {
        public SchoolCommunityContext() { }

        public SchoolCommunityContext(DbContextOptions<SchoolCommunityContext> options):
        base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Community> Communities { get; set; }
        public DbSet<CommunityMembership> CommunityMemberships { get; set; }
    

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=students.db");
            optionsBuilder.UseSqlite("Data Source=community.db");
            optionsBuilder.UseSqlite("Data Source=communitymembership.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Community>().ToTable("Community");
            modelBuilder.Entity<CommunityMembership>().ToTable("Community Membership");
            modelBuilder.Entity<CommunityMembership>().HasKey(c => new { c.StudentID, c.CommunityID });

        }

    }
}
