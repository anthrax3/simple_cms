using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace simple_cms.Models
{
    public class Page
    {
        public int PageId { get; set; }
        [Display(Name = "Subject Id")]
        public int SubjectId { get; set; }
        [Display(Name = "Page Name")]
        public string PageName { get; set; }
        [Display(Name = "Page Position")]
        public int PagePosition { get; set; }
        [Display(Name = "Page Visible")]
        public bool PageVisible { get; set; }
        [Display(Name = "Page Content")]
        [DataType(DataType.MultilineText)]
        public string PageContent { get; set; }

        public ICollection<Subject> Subjects { get; set; }  
    }
}