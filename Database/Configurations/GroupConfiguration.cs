using Koshkinegor_WebApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Koshkinegor_WebApplication.Database.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        private const string TableName = "group";

        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder
                .HasKey(p => p.GroupId)
                .HasName($"pk_{TableName}_group_id");

            builder
                .Property(p => p.GroupId)
                .HasColumnName("group_id")
                .HasColumnType("integer")
                .ValueGeneratedOnAdd();

            builder
                .Property(p => p.Name)
                .HasColumnName("name")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(p => p.Course)
                .HasColumnName("course")
                .HasColumnType("integer")
                .IsRequired();

            builder
                .Property(p => p.SpecialtyId)
                .HasColumnName("specialty_id")
                .HasColumnType("integer")
                .IsRequired();

            builder
                .Property(p => p.isDeleted)
                .HasColumnName("is_deleted")
                .HasColumnType("boolean")
                .HasDefaultValue(false)
                .IsRequired();

            builder
                .HasOne(p => p.Specialty)
                .WithMany(s => s.Groups)
                .HasForeignKey(p => p.SpecialtyId)
                .HasConstraintName("fk_group_specialty_id")
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasIndex(p => p.SpecialtyId)
                .HasDatabaseName($"idx_{TableName}_fk_specialty_id");

            builder
                .Navigation(p => p.Specialty)
                .AutoInclude();
        }
    }
}