using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter
{
    class HunterContext:DbContext
    {
        public HunterContext():base("HunterDataBase")
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<HunterContext>());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
