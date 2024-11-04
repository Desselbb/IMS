﻿

namespace IMSClassLibrary.Models
{
    public class InternProject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Key]
        [Required]
        [ForeignKey(nameof(Project))]
        public int ProjectId { get; set; }
        [Required]
        [ForeignKey(nameof(Profile))]
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
        public Project Project { get; set; }

    }
}
