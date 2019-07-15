using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private BigShopDbContext dbContext;

        public BigShopDbContext Init()
        {
            return dbContext ?? (dbContext = new BigShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}