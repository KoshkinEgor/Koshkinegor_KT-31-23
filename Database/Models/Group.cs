namespace Koshkinegor_WebApplication.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public int Course { get; set; }
        public int SpecialtyId { get; set; }
        public bool isDeleted { get; set; }
        public Specialty Specialty { get; set; }
        public IList<Student> Students { get; set; } = new List<Student>();
    }
}
