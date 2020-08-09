using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sameh.Entities
{
   public class BaseUser
    {
        public Guid Id { get; set; }
        public string  Name { get; set; }
        public string NationalCode { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
