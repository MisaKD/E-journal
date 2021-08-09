
namespace E_journal.Models
{
    public class Group
    {
        public int Id { get; set; }        
        public string Name { get; set; }        
        public string Specialization { get; set; }        
        public int Year { get; set; }        
        public string Curator { get; set; }
        public Course Course { get; set; }
        public int CourseId { get; set; }
    }
}
