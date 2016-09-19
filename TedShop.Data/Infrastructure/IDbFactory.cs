using System;
using TedShop.Data;

namespace TeduShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        TeduShopDbContext Init();
    }
}