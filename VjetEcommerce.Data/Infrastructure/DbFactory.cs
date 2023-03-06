using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjetEcommerce.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private VjetEcommerceDbContext dbContext;

        public VjetEcommerceDbContext Init()
        {
            return dbContext ?? (dbContext = new VjetEcommerceDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
