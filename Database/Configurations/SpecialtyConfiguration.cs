using Koshkinegor_WebApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Koshkinegor_WebApplication.Database.Configurations
{
    public class SpecialtyConfiguration : IEntityTypeConfiguration<Specialty>
    {
        private const string TableName = "specialty";

        public void Configure(EntityTypeBuilder<Specialty> builder)
        {
            builder
                .HasKey(p => p.SpecialtyId)
                .HasName($"pk_{TableName}_specialty_id");

            builder
                .Property(p => p.SpecialtyId)
                .HasColumnName("specialty_id")
                .HasColumnType("integer")
                .ValueGeneratedOnAdd();

            builder
                .Property(p => p.Title)
                .HasColumnName("title")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

            builder
                .Property(p => p.Code)
                .HasColumnName("code")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}