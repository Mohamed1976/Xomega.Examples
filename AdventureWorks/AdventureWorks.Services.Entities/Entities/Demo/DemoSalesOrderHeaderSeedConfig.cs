//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "EF Domain Objects" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdventureWorks.Services.Entities
{
    public class DemoSalesOrderHeaderSeedConfig : IEntityTypeConfiguration<DemoSalesOrderHeaderSeed>
    {
        public void Configure(EntityTypeBuilder<DemoSalesOrderHeaderSeed> c)
        {
            c.ToTable("DemoSalesOrderHeaderSeed", "Demo")
             .HasKey(e => e.LocalId);

            // configure properties
          
            c.Property(e => e.LocalId)
             .HasColumnName("LocalID")
             .HasColumnType("int")
             .IsRequired()
             .ValueGeneratedOnAdd();

            c.Property(e => e.DueDate)
             .HasColumnName("DueDate")
             .HasColumnType("datetime2")
             .IsRequired();

            c.Property(e => e.CustomerId)
             .HasColumnName("CustomerID")
             .HasColumnType("int")
             .IsRequired();

            c.Property(e => e.SalesPersonId)
             .HasColumnName("SalesPersonID")
             .HasColumnType("int")
             .IsRequired();

            c.Property(e => e.BillToAddressId)
             .HasColumnName("BillToAddressID")
             .HasColumnType("int")
             .IsRequired();

            c.Property(e => e.ShipToAddressId)
             .HasColumnName("ShipToAddressID")
             .HasColumnType("int")
             .IsRequired();

            c.Property(e => e.ShipMethodId)
             .HasColumnName("ShipMethodID")
             .HasColumnType("int")
             .IsRequired();

        }
    }
}