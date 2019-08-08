using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigShop.Data.Infrastructure;
using BigShop.Model.Models;

namespace BigShop.Data.Repositories
{
    public interface IPageRepository
    {
        IEnumerable<Page> GetByAlias(string alias);
    }

    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Page> GetByAlias(string alias)
        {
            return this.DbContext.Pages.Where(x => x.Alias == alias);
        }
    }
}