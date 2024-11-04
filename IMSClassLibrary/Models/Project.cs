

namespace IMSClassLibrary.Models
{
    public class Project
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]

        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }
    }
}
