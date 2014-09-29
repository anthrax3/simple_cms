using simple_cms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace simple_cms.Controllers
{
    public class PublicController : Controller
    {
        private CMSContext db = new CMSContext();
        // GET: Public
        public ActionResult Index()
        {
            PublicData data = new PublicData();
            data.subj = db.Subjects.ToList();
            data.pg = db.Pages.ToList();
            return View(data);  
        }

        public ActionResult SubjectPage(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Page page = db.Pages.Find(id);

            if (page == null)
            {
                return HttpNotFound();
            }

            PublicData data = new PublicData();
            data.subj = db.Subjects.ToList();
            data.pg = db.Pages.ToList();
            data.pageObj = page;

            return View(data);
        }
    }
}