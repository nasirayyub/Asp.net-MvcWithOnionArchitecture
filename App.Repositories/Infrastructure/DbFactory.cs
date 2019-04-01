using App.DataAccess;

namespace App.Repositories.Infrastructure
{
    public class DbFactory : IDbFactory
    {
        MyDbContext _dbContext;

      
        public MyDbContext Init()
        {
            return _dbContext ?? (_dbContext = new MyDbContext());
        }

    }
}
