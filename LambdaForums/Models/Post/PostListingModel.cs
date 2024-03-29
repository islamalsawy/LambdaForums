﻿using LambdaForums.Models.Forum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LambdaForums.Models.Post
{
    public class PostListingModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string AuthorRating { get; set; }
        public int AuthortId { get; set; }
        public string DatedPosted { get; set; }
        //public int ForumID { get; set; }
        //public string ForumImageURL { get; set; }
        //public string ForumName { get; set; }
        public int RepliesCount { get; set; }
        public ForumListingModel Forum { get; set; }





    }
}
