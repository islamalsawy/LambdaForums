using lambdaForums.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace lambdaForums.data
{
  public interface IPost
    {
        Post GetById(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetFilteredPosts(string searchQuery);
        Task Add(Post post);
        Task Delete(int Id);

        Task EditPostContent(int id, string newContent);
      


    }
}
