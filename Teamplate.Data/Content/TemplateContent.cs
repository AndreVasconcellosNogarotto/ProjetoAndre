using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Teamplate.Data.Extensions;
using Teamplate.Data.Mapping;
using Teamplate.Domain.Entities;

namespace Teamplate.Data.Content
{
    public class TemplateContent : DbContext
    {

        public TemplateContent(DbContextOptions<TemplateContent> options) : base(options)
        {

        }

        #region "DbSets"

        public DbSet<User> Users { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());

            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }
    }
}
