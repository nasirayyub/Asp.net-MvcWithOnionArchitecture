using System.Data.Entity;
using App.DataAccess.DbModels;

namespace App.DataAccess
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("DefaultConnection") { }

        public DbSet<User> User { get; set; }


        public virtual void Commit()
        {
            base.SaveChanges();
        }

    }
}
