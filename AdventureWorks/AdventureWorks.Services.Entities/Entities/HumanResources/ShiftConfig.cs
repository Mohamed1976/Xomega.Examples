//---------------------------------------------------------------------------------------------
// This file was AUTO-GENERATED by "EF Domain Objects" Xomega.Net generator.
//
// Manual CHANGES to this file WILL BE LOST when the code is regenerated.
//---------------------------------------------------------------------------------------------

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdventureWorks.Services.Entities
{
    public class ShiftConfig : IEntityTypeConfiguration<Shift>
    {
        public void Configure(EntityTypeBuilder<Shift> c)
        {
            c.ToTable("Shift", "HumanResources")
             .HasKey(e => e.ShiftId);

            // configure properties
          
            c.Property(e => e.ShiftId)
             .HasColumnName("ShiftID")
             .HasColumnType("tinyint")
             .IsRequired()
             .ValueGeneratedOnAdd();

            c.Property(e => e.Name)
             .HasColumnName("Name")
             .HasColumnType("nvarchar")
             .HasMaxLength(50)
             .IsUnicode()
             .IsRequired();

            c.Property(e => e.StartTime)
             .HasColumnName("StartTime")
             .HasColumnType("time")
             .IsRequired();

            c.Property(e => e.EndTime)
             .HasColumnName("EndTime")
             .HasColumnType("time")
             .IsRequired();

            c.Property(e => e.ModifiedDate)
             .HasColumnName("ModifiedDate")
             .HasColumnType("datetime")
             .IsRequired();

        }
    }
}