//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "EF Domain Objects" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdventureWorks.Services.Entities
{
    public class BillOfMaterialsConfig : IEntityTypeConfiguration<BillOfMaterials>
    {
        public void Configure(EntityTypeBuilder<BillOfMaterials> c)
        {
            c.ToTable("BillOfMaterials", "Production")
             .HasKey(e => e.BillOfMaterialsId);

            // configure relationships

            c.HasOne(e => e.ProductAssemblyObject)
             .WithMany()
             .HasForeignKey(e => e.ProductAssemblyId);

            c.HasOne(e => e.ComponentObject)
             .WithMany()
             .HasForeignKey(e => e.ComponentId);

            c.HasOne(e => e.UnitMeasureCodeObject)
             .WithMany()
             .HasForeignKey(e => e.UnitMeasureCode);

            // configure properties
          
            c.Property(e => e.BillOfMaterialsId)
             .HasColumnName("BillOfMaterialsID")
             .HasColumnType("int")
             .IsRequired()
             .ValueGeneratedOnAdd();

            c.Property(e => e.ProductAssemblyId)
             .HasColumnName("ProductAssemblyID")
             .HasColumnType("int");

            c.Property(e => e.ComponentId)
             .HasColumnName("ComponentID")
             .HasColumnType("int")
             .IsRequired();

            c.Property(e => e.StartDate)
             .HasColumnName("StartDate")
             .HasColumnType("datetime")
             .IsRequired();

            c.Property(e => e.EndDate)
             .HasColumnName("EndDate")
             .HasColumnType("datetime");

            c.Property(e => e.UnitMeasureCode)
             .HasColumnName("UnitMeasureCode")
             .HasColumnType("nchar")
             .HasMaxLength(3)
             .IsUnicode()
             .IsFixedLength()
             .IsRequired();

            c.Property(e => e.BomLevel)
             .HasColumnName("BOMLevel")
             .HasColumnType("smallint")
             .IsRequired();

            c.Property(e => e.PerAssemblyQty)
             .HasColumnName("PerAssemblyQty")
             .HasColumnType("decimal(8,2)")
             .IsRequired();

            c.Property(e => e.ModifiedDate)
             .HasColumnName("ModifiedDate")
             .HasColumnType("datetime")
             .IsRequired();

        }
    }
}