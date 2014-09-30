using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace simple_cms.Models
{
    public class PublicData
    {
        public Subject subject { get; set; }
        public List<Subject> subj { get; set; }
        public List<Page> pg { get; set; }
        public Page pageObj { get; set; }
    }
}