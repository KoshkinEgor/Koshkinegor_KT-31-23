using Koshkinegor_WebApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Koshkinegor_WebApplication.Database.Configurations
{
    public class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {
        private const string TableName = "grade";

        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder
                .HasKey(p => p.GradeId)
                .HasName($"pk_{TableName}_grade_id");

            builder
                .Property(p => p.GradeId)
                .HasColumnName("grade_id")
                .HasColumnType("integer")
                .ValueGeneratedOnAdd();

            builder
                .Property(p => p.Value)
                .HasColumnName("value")
                .HasColumnType("integer")
                .IsRequired();

            builder
                .Property(p => p.LastName)
                .HasColumnName("last_name")
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(p => p.StudentId)
                .HasColumnName("student_id")
                .HasColumnType("integer")
                .IsRequired();

            builder
                .Property(p => p.DisciplineId)
                .HasColumnName("discipline_id")
                .HasColumnType("integer")
                .IsRequired();

            // Связь: оценка принадлежит одному студенту, у студента много оценок
            builder
                .HasOne(p => p.Student)
                .WithMany(s => s.Grades)
                .HasForeignKey(p => p.StudentId)
                .HasConstraintName("fk_grade_student_id")
                .OnDelete(DeleteBehavior.Cascade);

            // Связь: оценка относится к одной дисциплине, у дисциплины много оценок
            builder
                .HasOne(p => p.Discipline)
                .WithMany(d => d.Grades)
                .HasForeignKey(p => p.DisciplineId)
                .HasConstraintName("fk_grade_discipline_id")
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasIndex(p => p.StudentId)
                .HasDatabaseName($"idx_{TableName}_fk_student_id");

            builder
                .HasIndex(p => p.DisciplineId)
                .HasDatabaseName($"idx_{TableName}_fk_discipline_id");

            builder
                .Navigation(p => p.Student)
                .AutoInclude();

            builder
                .Navigation(p => p.Discipline)
                .AutoInclude();
        }
    }
}