using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Model.Models.Mapping;

namespace Model.Models
{
    public partial class DemoCtsContext : DbContext
    {
        static DemoCtsContext()
        {
            Database.SetInitializer<DemoCtsContext>(null);
        }

        public DemoCtsContext()
            : base("Name=DemoCtsContext")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new OrderItemMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
        }
    }
}
