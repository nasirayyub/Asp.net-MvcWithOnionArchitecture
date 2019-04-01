using App.Models.Models;
using System.Collections.Generic;

namespace App.Services.Interfaces
{
    public interface IUserService
   {
       List<UserModel> AllUsers();
   }
}
