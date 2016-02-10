using System.Data.Entity;
namespace FlowingThroughMountains.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("FlowingThroughMountains")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}