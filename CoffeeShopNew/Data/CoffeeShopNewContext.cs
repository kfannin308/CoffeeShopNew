using CoffeeShopNew.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShopNew.Data
{
    public class CoffeeShopNewContext: DbContext
    {
        public DbSet<Products> Products { get; set; } = null;
    }

    
}
