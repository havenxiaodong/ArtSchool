using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using School.Models;

namespace School.Controllers
{
    public class SubjectController : Controller
    {
        //
        // GET: /Subject/
        private school2014Entities aa = new school2014Entities();
        public PartialViewResult _Index1(int SunIndex = 1)
        {
            List<SubjectSet> sub = aa.Subject.OrderByDescending(x => x.time).Where(x=>x.kind=="办学体系").Take(7).ToList();
            return PartialView(sub);
        }   
        public PartialViewResult _Index2(int SunIndex = 1)
        {
            List<SubjectSet> sub = aa.Subject.OrderByDescending(x => x.time).Where(x => x.kind == "学科设置").Take(7).ToList();
            return PartialView(sub);
        }
        public PartialViewResult _Index3(int SunIndex = 1)
        {
            List<SubjectSet> sub = aa.Subject.OrderByDescending(x => x.time).Where(x => x.kind == "硕士点").Take(7).ToList();
            return PartialView(sub);
        }
        public PartialViewResult _Index4(int SunIndex = 1)
        {
            List<SubjectSet> sub = aa.Subject.OrderByDescending(x => x.time).Where(x => x.kind == "学术交流").Take(7).ToList();
            return PartialView(sub);
        }
        public ActionResult Details(int id)
        {
            var mes = aa.Subject.Single(x => x.ID == id);
            return View(mes);
        }

    }
}
