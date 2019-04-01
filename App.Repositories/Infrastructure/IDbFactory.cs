using App.DataAccess;

namespace App.Repositories.Infrastructure
{
    public interface IDbFactory
    {
        MyDbContext Init();
    }
}
