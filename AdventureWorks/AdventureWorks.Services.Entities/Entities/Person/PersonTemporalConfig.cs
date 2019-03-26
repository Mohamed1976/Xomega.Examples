//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "EF Domain Objects" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdventureWorks.Services.Entities
{
    public class PersonTemporalConfig : IEntityTypeConfiguration<PersonTemporal>
    {
        public void Configure(EntityTypeBuilder<PersonTemporal> c)
        {
            c.ToTable("Person_Temporal", "Person")
             .HasKey(e => e.BusinessEntityId);

            // configure properties
          
            c.Property(e => e.BusinessEntityId)
             .HasColumnName("BusinessEntityID")
             .HasColumnType("int")
             .IsRequired()
             .ValueGeneratedNever();

            c.Property(e => e.PersonType)
             .HasColumnName("PersonType")
             .HasColumnType("nchar")
             .HasMaxLength(2)
             .IsUnicode()
             .IsFixedLength()
             .IsRequired();

            c.Property(e => e.NameStyle)
             .HasColumnName("NameStyle")
             .HasColumnType("bit")
             .IsRequired();

            c.Property(e => e.Title)
             .HasColumnName("Title")
             .HasColumnType("nvarchar")
             .HasMaxLength(8)
             .IsUnicode();

            c.Property(e => e.FirstName)
             .HasColumnName("FirstName")
             .HasColumnType("nvarchar")
             .HasMaxLength(50)
             .IsUnicode()
             .IsRequired();

            c.Property(e => e.MiddleName)
             .HasColumnName("MiddleName")
             .HasColumnType("nvarchar")
             .HasMaxLength(50)
             .IsUnicode();

            c.Property(e => e.LastName)
             .HasColumnName("LastName")
             .HasColumnType("nvarchar")
             .HasMaxLength(50)
             .IsUnicode()
             .IsRequired();

            c.Property(e => e.Suffix)
             .HasColumnName("Suffix")
             .HasColumnType("nvarchar")
             .HasMaxLength(10)
             .IsUnicode();

            c.Property(e => e.EmailPromotion)
             .HasColumnName("EmailPromotion")
             .HasColumnType("int")
             .IsRequired();

            c.Property(e => e.ValidFrom)
             .HasColumnName("ValidFrom")
             .HasColumnType("datetime2")
             .IsRequired();

            c.Property(e => e.ValidTo)
             .HasColumnName("ValidTo")
             .HasColumnType("datetime2")
             .IsRequired();

        }
    }
}