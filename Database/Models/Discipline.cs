namespace Koshkinegor_WebApplication.Models
{
    public class Discipline
    {
        public int DisciplineId { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public IList<Grade> Grades { get; set; } = new List<Grade>();
    }
}
