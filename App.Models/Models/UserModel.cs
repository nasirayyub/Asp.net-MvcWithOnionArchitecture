using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Models
{
   public class UserModel
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ProfilePicturePath { get; set; }

        public string Location { get; set; }

        public string Alias { get; set; }

        public string DateOfBrith { get; set; }

        public string PhoneNumber { get; set; }
    }
}
