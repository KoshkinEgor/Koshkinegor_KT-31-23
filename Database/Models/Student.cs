namespace Koshkinegor_WebApplication.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GroupId { get; set; }
        public bool IsDeleted { get; set; }
        public Group Group { get; set; }
        public IList<Grade> Grades { get; set; } = new List<Grade>();
    }
}
