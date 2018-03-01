using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class OrderItemMap : EntityTypeConfiguration<OrderItem>
    {
        public OrderItemMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("OrderItem");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.order_id).HasColumnName("order_id");
            this.Property(t => t.product_id).HasColumnName("product_id");
            this.Property(t => t.quantity).HasColumnName("quantity");

            // Relationships
            this.HasOptional(t => t.Order)
                .WithMany(t => t.OrderItems)
                .HasForeignKey(d => d.order_id);
            this.HasOptional(t => t.Product)
                .WithMany(t => t.OrderItems)
                .HasForeignKey(d => d.product_id);

        }
    }
}
