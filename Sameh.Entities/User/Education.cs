using System;
using System.Collections.Generic;
using System.Text;

namespace Sameh.Entities.User
{
   public class Education
    {
        public int Id { get; set; }
        public EducationType EducationType { get; set; }
        public string EducationName { get; set; }
        public string Description { get; set; }
        public BaseUser BaseUser { get; set; }
    }
}
