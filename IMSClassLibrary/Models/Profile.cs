﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace IMSClassLibrary.Models
{
    public class Profile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        [StringLength(50)]
        public string Name { get; set; }


        [StringLength(50)]
        public string Status { get; set; }



        [StringLength(50)]
        public string CreatedBy { get; set; }


        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;


        [StringLength(50)]
        public string ModifiedBy { get; set; }


        [DataType(DataType.DateTime)]
        public DateTime ModifiedDate { get; set; } = DateTime.Now;

    }
}
