using App.DataAccess.DbModels;
using App.Repositories.Infrastructure;
using System.Collections.Generic;

namespace App.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        List<User> GetAllUsers();
    }
}
