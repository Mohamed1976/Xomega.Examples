//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "EF Domain Objects" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdventureWorks.Services.Entities
{
    public class BusinessEntityContactConfig : IEntityTypeConfiguration<BusinessEntityContact>
    {
        public void Configure(EntityTypeBuilder<BusinessEntityContact> c)
        {
            c.ToTable("BusinessEntityContact", "Person")
             .HasKey(e => new { e.BusinessEntityId, e.PersonId, e.ContactTypeId });

            // configure relationships

            c.HasOne(e => e.BusinessEntityObject)
             .WithMany()
             .HasForeignKey(e => e.BusinessEntityId);

            c.HasOne(e => e.PersonObject)
             .WithMany()
             .HasForeignKey(e => e.PersonId);

            c.HasOne(e => e.ContactTypeObject)
             .WithMany()
             .HasForeignKey(e => e.ContactTypeId);

            // configure properties
          
            c.Property(e => e.BusinessEntityId)
             .HasColumnName("BusinessEntityID")
             .HasColumnType("int")
             .IsRequired();

            c.Property(e => e.PersonId)
             .HasColumnName("PersonID")
             .HasColumnType("int")
             .IsRequired();

            c.Property(e => e.ContactTypeId)
             .HasColumnName("ContactTypeID")
             .HasColumnType("int")
             .IsRequired();

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