using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model.Mint;
using Model.Global;

namespace HomeCFOContext
{
    public class Context : DbContext
    {
        public Context() : base("name=HomeCFO")
        {
            Database.SetInitializer<Context>(new DropCreateDatabaseAlways<Context>());
        }
        //Global Entities
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Grouping> Groupings { get; set; }
        public DbSet<StatementClassification> StatementClassifications { get; set; }

        //Mint Entities
        public DbSet<Group> Groups { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Activity> Activities { get; set; }
    }
}
