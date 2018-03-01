using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Model.Models.Mapping
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.name)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.surname)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.email)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.password)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.phoneNo)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Customer");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.surname).HasColumnName("surname");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.phoneNo).HasColumnName("phoneNo");
        }
    }
}