using System;
using System.Collections.Generic;
using System.Text;

namespace Sameh.Entities.User
{

   public class UserContact
    {
        public int Id { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public BaseUser BaseUser { get; set; }
    }
}
