using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.DbModels
{
   public class User : BaseModel
    {
        [Key]
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
