//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "EF Domain Objects" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdventureWorks.Services.Entities
{
    public class CountryRegionCurrencyConfig : IEntityTypeConfiguration<CountryRegionCurrency>
    {
        public void Configure(EntityTypeBuilder<CountryRegionCurrency> c)
        {
            c.ToTable("CountryRegionCurrency", "Sales")
             .HasKey(e => new { e.CountryRegionCode, e.CurrencyCode });

            // configure relationships

            c.HasOne(e => e.CountryRegionCodeObject)
             .WithMany()
             .HasForeignKey(e => e.CountryRegionCode);

            c.HasOne(e => e.CurrencyCodeObject)
             .WithMany()
             .HasForeignKey(e => e.CurrencyCode);

            // configure properties
          
            c.Property(e => e.CountryRegionCode)
             .HasColumnName("CountryRegionCode")
             .HasColumnType("nvarchar")
             .HasMaxLength(3)
             .IsUnicode()
             .IsRequired();

            c.Property(e => e.CurrencyCode)
             .HasColumnName("CurrencyCode")
             .HasColumnType("nchar")
             .HasMaxLength(3)
             .IsUnicode()
             .IsFixedLength()
             .IsRequired();

            c.Property(e => e.ModifiedDate)
             .HasColumnName("ModifiedDate")
             .HasColumnType("datetime")
             .IsRequired();

        }
    }
}