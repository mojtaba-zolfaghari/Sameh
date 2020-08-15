using System;
using System.Collections.Generic;
using System.Text;

namespace Sameh.Entities.User
{
   public class UserBanksAccount
    {
        public int Id { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string CardNumber { get; set; }
        public string ShabaNumber { get; set; }
        public virtual BaseUser BaseUser { get; set; }
    }
}
