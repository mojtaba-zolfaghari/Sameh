using System;
using System.Collections.Generic;
using System.Text;

namespace Sameh.Entities.User
{
   public class UserMilitary
    {
        public int Id { get; set; }
        public MilitaryServiceStatus MilitaryServiceStatus { get; set; }
        public DateTime? EndDateOfExemption { get; set; }
        public BaseUser BaseUser { get; set; }

    }
}
