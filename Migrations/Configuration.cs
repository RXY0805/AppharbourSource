namespace FIFA14.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using FIFA14.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<FIFA14.DAL.FIFA14Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            //AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(FIFA14.DAL.FIFA14Context context)
        {
            try
            {
                GetGroups().ForEach(g => context.Groups.Add(g));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        private static List<Group> GetGroups()
        {
            return new List<Group>
            {
                new Group
                {
                    Title="A"
                },
                new Group
                {
                    Title="B"
                },
                new Group
                {
                    Title="C"
                },
                 new Group
                {
                    Title="D"
                },
                 new Group
                {
                    Title="E"
                }
            };
        }
    }
}
