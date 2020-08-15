using Sameh.Entities.User;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sameh.Entities
{
   public class BaseUser
    {
        public Guid Id { get; set; }
        public ApplicantType ApplicantType { get; set; }

        public int UserContactId { get; set; }
        public UserContact UserContact { get; set; }

        public int IDInformationId { get; set; }
        public IDInformation IDInformation { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }

        public int EducationId { get; set; }
        public Education Education { get; set; }

        public int UserMilitaryId { get; set; }
        public UserMilitary UserMilitary { get; set; }

        public virtual ICollection<UserBanksAccount> UserBanksAccount { get; set; }
        public MaritalType MaritalType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

    }
}
