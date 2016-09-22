using System.Data.Entity;
using WP.Service.Models;

namespace WP.Service.EntityContext
{
    public class WpContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Alternative> Alternatives { get; set; }
        public DbSet<Prediction> Predictions { get; set; }

        public WpContext() : base("name=WpDb")
        {
            
        }
    }
}