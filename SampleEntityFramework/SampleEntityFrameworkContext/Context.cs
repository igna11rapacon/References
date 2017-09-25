using SampleEntityFrameworkAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFrameworkContext
{
    public class Context : DbContext
    {
        public Context() : base("SampleEntityFramework")
        {
            Database.SetInitializer(new DBInitializer());

            if (Database.Exists())
            {
                Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Migrations.Configuration>()); //mag eeror ang part na ito kung wala pa kyung migration
            }
            else
            {
                Database.SetInitializer(new DBInitializer());
            }
        }

        public class DBInitializer : CreateDatabaseIfNotExists<Context>
        {
            public DBInitializer()
            {
            }
            protected override void Seed(Context context)
            {
                context.Credentials.Add(
                    new Credential
                    {
                        Username = "sample",
                        Password = "sample"
                    });
                context.SaveChanges();
                base.Seed(context);
            }
        }
        public DbSet<Credential> Credentials { get; set; }
    }
}
