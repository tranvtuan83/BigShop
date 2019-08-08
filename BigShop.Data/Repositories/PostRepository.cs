using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigShop.Data.Infrastructure;
using BigShop.Model.Models;

namespace BigShop.Data.Repositories
{
    public interface IPostRepository
    {
        IEnumerable<Post> GetByAlias(string alias);
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Post> GetByAlias(string alias)
        {
            return this.DbContext.Posts.Where(x => x.Alias == alias);
        }
    }
}