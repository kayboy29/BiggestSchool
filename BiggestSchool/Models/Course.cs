using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BiggestSchool.Models
{
    public class Course
    {
        public int Id { get; set; }
        public ApplicationUser Lecturer { get; set; }
        [required]
        public string LectureID { get; set; }
        [required]
        [StringLength(255)]
        public string Place { get; set; }
        public DateTime Datetime { get; set; }
        public Category Category { get; set; }
        [required]
        public byte CategoryID { get; set; }
    }
}