using lambdaForums.data;
using lambdaForums.data.Models;
using LambdaForums.Data;
using LambdaForums.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lamdbaForums.Service
{
    public class ForumService : IForum  //implement IForum intercface
    {
        private readonly ApplicationDbContext _context;
        public ForumService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task Create(Forum forum)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int forumId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Forum> Getall()
        {
            return _context.Forums
                .Include(forum =>forum.Posts); //return collotions of forums from db (LOAD EXPLICITY)
        }

        public IEnumerable<ApplicationUser> GetAllActiveUsers()
        {
            throw new NotImplementedException();
        }

        public Forum GetById(int id)
        {
            var forum = _context.Forums.Where(f => f.Id == id)
                   .Include(f => f.Posts).ThenInclude(p => p.User)
                   .Include(f => f.Posts).ThenInclude(p => p.Replies)
                   .ThenInclude(r => r.User)
                   .FirstOrDefault(); // return a single instance of a forum rather than collection of forums
            return forum;

        }

        public Task updateForumDescription(int forumId, string newDescription)
        {
            throw new NotImplementedException();
        }

        public Task updateForumTitle(int forumId, string newTitle)
        {
            throw new NotImplementedException();
        }
    }
}
