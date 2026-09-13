namespace Koshkinegor_WebApplication.Models
{
    public class Specialty
    {
        public int SpecialtyId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public IList<Group> Groups { get; set; }
    }
}
