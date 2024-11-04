using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMSClassLibrary.Enums;




namespace IMSClassLibrary.Models
{
    public class ProjectComments
    {
        public int Id { get; set; }
        public string? LastName { get; set; }
        [Required]
        [ForeignKey(nameof(Project))]
        public int ProjectId { get; set; }
        [Required]
        public DateTime CommentDate { get; set; } = DateTime.Now;
        [Required]
        public string Message { get; set; }
        public Log Log { get; set; }
        [Required]
        public User Users { get; set; }
        [Required]
        [ForeignKey(nameof(User))]
        public string? FirstName { get; set; }
        [Required]
        [ForeignKey(nameof(User))]
        public string? LasttName { get; set; }

    }
}
