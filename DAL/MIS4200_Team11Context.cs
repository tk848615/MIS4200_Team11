using System;
using System.Collections.Generic;
using System.Data.Entity;
using MIS4200_Team11.Models;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace MIS4200_Team11.DAL
{
    public class MIS4200_Team11Context : DbContext
    {
        public MIS4200_Team11Context() : base("name=DefaultConnection")
        {
           Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200_Team11Context, MIS4200_Team11.Migrations.MISContext.Configuration>("DefaultConnection"));
            // this method is a 'constructor' and is called when a new context is created
            // the base attribute says which connection string to use
        }
        public DbSet<UserDetails> UserDetails { get; set; }

        public DbSet<Recognition> Recognitions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }

       
    }
}