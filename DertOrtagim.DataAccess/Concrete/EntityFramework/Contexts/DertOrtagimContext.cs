using Core.Entities.SecurityModels;
using DertOrtagim.Entities.DBModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DertOrtagim.DataAccess.Concrete.EntityFramework.Contexts
{
    public class DertOrtagimDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=DERTORTAGIMDB;Trusted_Connection=false;User Id=dertortagim;Password=dertortagim123");
        }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<ProfilePicture> ProfilePictures { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
