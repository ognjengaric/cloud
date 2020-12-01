using System;
using System.Collections.Generic;
using System.Text;
using cloud_app.Domain;
using Microsoft.EntityFrameworkCore;

namespace cloud_app.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Data> Data { get; set; }
        
        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }
    }

}
