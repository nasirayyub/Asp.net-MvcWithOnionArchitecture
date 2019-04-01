using App.DataAccess;

namespace App.Repositories.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly IDbFactory dbFactory;
        private MyDbContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public MyDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.Commit();
        }
    }
}
