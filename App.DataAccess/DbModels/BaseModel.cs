using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DataAccess.DbModels
{
   public abstract class BaseModel
    {
        protected BaseModel()
        {
            IsDeleted = false;
        }

        public bool IsDeleted { get; set; }
        public DateTimeOffset CreatedDateTime { get; set; }
        public Guid CreatedUsedId { get; set; }
        public DateTimeOffset? UpdatedDateTime { get; set; }
        public Guid? UpdatedUserId { get; set; }
    }
}
