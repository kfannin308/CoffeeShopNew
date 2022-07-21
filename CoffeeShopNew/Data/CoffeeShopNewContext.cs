using CoffeeShopNew.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShopNew.Data
{
    public class CoffeeShopNewContext: DbContext
    {
        public CoffeeShopNewContext(DbContextOptions<CoffeeShopNewContext> options) : base(options)

        {

            // Nothing needed

        }
        public DbSet<Products> Products { get; set; }
    }

    
}
