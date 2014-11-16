using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using School.Models;
using Webdiyer;
using Webdiyer.WebControls.Mvc;
namespace School.Controllers
{
    public class ScienceController : Controller
    {
        //
        // GET: /science/
        private school2014Entities tt = new school2014Entities();
        public PartialViewResult _Index1(int ScienceIndex = 1)
        {
            PagedList<scienceSet> sub = tt.science.OrderByDescending(x => x.time).Where(x => x.kind == "科研机构").ToPagedList(ScienceIndex, 7);
            return PartialView(sub);
        }
        public PartialViewResult _Index2(int ScienceIndex = 1)
        {
            PagedList<scienceSet> sub = tt.science.OrderByDescending(x => x.time).Where(x => x.kind == "科研通知").ToPagedList(ScienceIndex, 7);
            return PartialView(sub);
        }
        public PartialViewResult _Index3(int ScienceIndex = 1)
        {
            PagedList<scienceSet> sub = tt.science.OrderByDescending(x => x.time).Where(x => x.kind == "科研成果").ToPagedList(ScienceIndex, 7);
            return PartialView(sub);
        }
        public ActionResult Details(int id)
        {
            var mes = tt.science.Single(x => x.ID == id);
            return View(mes);
        }
    }
}
