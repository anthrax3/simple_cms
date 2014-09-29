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
        public int SubjectId { get; set; }
        public string PageName { get; set; }
        public int PagePosition { get; set; }
        public bool PageVisible { get; set; }
        [DataType(DataType.MultilineText)]
        public string PageContent { get; set; }

        public ICollection<Subject> Subjects { get; set; }  
    }
}