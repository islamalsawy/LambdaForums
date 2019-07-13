using LambdaForums.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace lambdaForums.Data.Models
{
   public class PostReply
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime created { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual Post Post { get; set; }

    }
}
