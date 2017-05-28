using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model.Mint;

namespace HomeCFOContext
{
    public class Context : DbContext
    {
        public Context() : base("name=HomeCFO")
        {
        }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Activity> Activities { get; set; }
    }
}
