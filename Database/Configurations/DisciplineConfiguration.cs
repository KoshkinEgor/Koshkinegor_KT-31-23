using Koshkinegor_WebApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Koshkinegor_WebApplication.Database.Configurations
{
    public class DisciplineConfiguration : IEntityTypeConfiguration<Discipline>
    {
        private const string TableName = "discipline";

        public void Configure(EntityTypeBuilder<Discipline> builder)
        {
            builder
                .HasKey(p => p.DisciplineId)
                .HasName($"pk_{TableName}_discipline_id");

            builder
                .Property(p => p.DisciplineId)
                .HasColumnName("discipline_id")
                .HasColumnType("integer")
                .ValueGeneratedOnAdd();

            builder
                .Property(p => p.Name)
                .HasColumnName("name")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

            builder
                .Property(p => p.IsDeleted)
                .HasColumnName("is_deleted")
                .HasColumnType("boolean")
                .HasDefaultValue(false)
                .IsRequired();
        }
    }
}