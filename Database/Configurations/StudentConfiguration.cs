using Koshkinegor_WebApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Koshkinegor_WebApplication.Database.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        private const string TableName = "student";

        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder
                .HasKey(p => p.StudentId)
                .HasName($"pk_{TableName}_student_id");

            builder
                .Property(p => p.StudentId)
                .HasColumnName("student_id")
                .HasColumnType("integer")
                .ValueGeneratedOnAdd();

            builder
                .Property(p => p.FirstName)
                .HasColumnName("first_name")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(p => p.LastName)
                .HasColumnName("last_name")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(p => p.GroupId)
                .HasColumnName("group_id")
                .HasColumnType("integer")
                .IsRequired();

            builder
                .Property(p => p.IsDeleted)
                .HasColumnName("is_deleted")
                .HasColumnType("boolean")
                .HasDefaultValue(false)
                .IsRequired();

            builder
                .HasOne(p => p.Group)
                .WithMany(g => g.Students)
                .HasForeignKey(p => p.GroupId)
                .HasConstraintName("fk_student_group_id")
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasIndex(p => p.GroupId)
                .HasDatabaseName($"idx_{TableName}_fk_group_id");

            builder
                .Navigation(p => p.Group)
                .AutoInclude();
        }
    }
}