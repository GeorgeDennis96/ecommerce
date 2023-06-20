using BlazorEcommerce.Shared.Models.Product;
using BlazorEcommerce.Shared.Models.Product.Admin;

namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<AdminProduct> AdminProducts {get; set;}

        public DbSet<Product> Products { get; set; }


    }
}
