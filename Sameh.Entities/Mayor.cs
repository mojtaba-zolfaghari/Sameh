using System;
using System.Collections.Generic;
using System.Text;

namespace Sameh.Entities
{
   public class Mayor:BaseUser
    {
        public string Post { get; set; }
        public virtual Municipality Municipality { get; set; }
        public int MyProperty { get; set; }
    }
   public class Post
    {
        public virtual Mayor Mayors { get; set; }
    }
}
