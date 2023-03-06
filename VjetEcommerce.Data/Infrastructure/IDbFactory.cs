using System;

namespace VjetEcommerce.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        VjetEcommerceDbContext Init();
    }
}