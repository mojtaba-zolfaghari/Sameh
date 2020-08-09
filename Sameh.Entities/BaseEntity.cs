using System;
using System.Collections.Generic;
using System.Text;

namespace Sameh.Entities
{
   public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
