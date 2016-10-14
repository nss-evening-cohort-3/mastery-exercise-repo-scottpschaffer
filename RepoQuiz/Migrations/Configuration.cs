namespace RepoQuiz.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;
    using DAL;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<RepoQuiz.DAL.StudentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RepoQuiz.DAL.StudentContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            StudentRepository sr = new StudentRepository();
            NameGenerator ng = new NameGenerator();
            List<Student> ls = sr.GetTenStudents();

            context.Students.AddOrUpdate(
                s => s.FirstName,
                new Student { FirstName = ls[0].FirstName, LastName = ls[0].LastName, Major = ls[0].Major },
                new Student { FirstName = ls[1].FirstName, LastName = ls[1].LastName, Major = ls[1].Major },
                new Student { FirstName = ls[2].FirstName, LastName = ls[2].LastName, Major = ls[2].Major },
                new Student { FirstName = ls[3].FirstName, LastName = ls[3].LastName, Major = ls[3].Major },
                new Student { FirstName = ls[4].FirstName, LastName = ls[4].LastName, Major = ls[4].Major },
                new Student { FirstName = ls[5].FirstName, LastName = ls[5].LastName, Major = ls[5].Major },
                new Student { FirstName = ls[6].FirstName, LastName = ls[6].LastName, Major = ls[6].Major },
                new Student { FirstName = ls[7].FirstName, LastName = ls[7].LastName, Major = ls[7].Major },
                new Student { FirstName = ls[8].FirstName, LastName = ls[8].LastName, Major = ls[8].Major },
                new Student { FirstName = ls[9].FirstName, LastName = ls[9].LastName, Major = ls[9].Major }
                );

        }
    }
}
