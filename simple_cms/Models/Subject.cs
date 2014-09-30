using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace simple_cms.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        [Display(Name = "Subject Name")]
        public string SubjectName { get; set; }
        [Display(Name = "Subject Position")]
        public int SubjectPosition { get; set; }
        [Display(Name = "Subject Visible")]
        public bool SubjectVisible { get; set; }

        public ICollection<Page> Pages { get; set; }
    }
}