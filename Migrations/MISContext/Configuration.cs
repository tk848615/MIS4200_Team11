namespace MIS4200_Team11.Migrations.MISContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MIS4200_Team11.DAL.MIS4200_Team11Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\MISContext";
            ContextKey = "MIS4200_Team11.DAL.MIS4200_Team11Context";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MIS4200_Team11.DAL.MIS4200_Team11Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
