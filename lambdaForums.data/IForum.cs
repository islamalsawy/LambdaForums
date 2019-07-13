using lambdaForums.data.Models;
using System.Collections.Generic;
using System;
using LambdaForums.Data.Models;
using System.Threading.Tasks;

namespace lambdaForums.data
{
    public interface IForum
    {
        Forum GetById(int id); // get a particular instance of a forum by its ID
        IEnumerable<Forum> Getall();
        IEnumerable<ApplicationUser> GetAllActiveUsers();
        //CRUD operations
        Task Create(Forum forum);
        Task Delete(int forumId);
        Task updateForumTitle(int forumId, string newTitle);
        Task updateForumDescription(int forumId, string newDescription);


    }
}
