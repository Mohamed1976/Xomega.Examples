//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "EF Domain Objects" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdventureWorks.Services.Entities
{
    public class StoreConfig : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> c)
        {
            c.ToTable("Store", "Sales")
             .HasKey(e => e.BusinessEntityId);

            // configure relationships

            c.HasOne(e => e.BusinessEntityObject)
             .WithOne()
             .HasForeignKey<Store>(e => e.BusinessEntityId);

            c.HasOne(e => e.SalesPersonObject)
             .WithMany()
             .HasForeignKey(e => e.SalesPersonId);

            // configure properties
          
            c.Property(e => e.BusinessEntityId)
             .HasColumnName("BusinessEntityID")
             .HasColumnType("int")
             .IsRequired()
             .ValueGeneratedNever();

            c.Property(e => e.Name)
             .HasColumnName("Name")
             .HasColumnType("nvarchar")
             .HasMaxLength(50)
             .IsUnicode()
             .IsRequired();

            c.Property(e => e.SalesPersonId)
             .HasColumnName("SalesPersonID")
             .HasColumnType("int");

            c.Property(e => e.Demographics)
             .HasColumnName("Demographics")
             .HasColumnType("xml");

            c.Property(e => e.Rowguid)
             .HasColumnName("rowguid")
             .HasColumnType("uniqueidentifier")
             .IsRequired();

            c.Property(e => e.ModifiedDate)
             .HasColumnName("ModifiedDate")
             .HasColumnType("datetime")
             .IsRequired();

        }
    }
}