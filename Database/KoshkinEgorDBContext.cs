using Koshkinegor_WebApplication.Database.Configurations;
using Koshkinegor_WebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace Koshkinegor_WebApplication.Database
{
    public class KoshkinEgorDBContext : DbContext
    {
        public KoshkinEgorDBContext(DbContextOptions<KoshkinEgorDBContext> options)
            : base(options)
        {
        }

        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Specialty> Specialtys { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.ApplyConfiguration(new SpecialtyConfiguration());
            modelBuilder.ApplyConfiguration(new DisciplineConfiguration());
            modelBuilder.ApplyConfiguration(new GradeConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}