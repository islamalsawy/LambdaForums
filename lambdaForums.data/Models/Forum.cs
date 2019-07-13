using System;
using System.Collections.Generic;
using System.Text;

namespace lambdaForums.data.Models
{
    public class Forum
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime created { get; set; }
        public string ImageUrl { get; set; }
        public virtual IEnumerable<Posts> Posts { get; set; }


    }
}
