using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.DataAccess.DbModels;
using App.Repositories.Infrastructure;
using App.Repositories.Interfaces;

namespace App.Repositories.Repositories
{
   public class UserRepository : RepositoryBase<User>, IUserRepository
   {
       
        public UserRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public List<User> GetAllUsers()
        {
            var allUsers = DbContext.User.ToList();
            return allUsers;
        }
    }
}
