using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webdiyer;
using Webdiyer.WebControls.Mvc;
using School.Models;


namespace School.Controllers
{
    public class YyfcController : Controller
    {
        //
        // GET: /Yyfc/
        private school2014Entities db = new school2014Entities();
        public ActionResult Index(int NewMes=1)
        {
            PagedList<ywshowSet> mes = db.ywshow.OrderByDescending(x => x.time).Where(x=>x.kind=="学院风采").ToPagedList(NewMes,7);
            
            return View(mes);
        }
        public ActionResult Index2(int NewMes = 1)
        {
            PagedList<ywshowSet> mes = db.ywshow.OrderByDescending(x => x.time).Where(x => x.kind == "校园电子报").ToPagedList(NewMes,7);

            return View(mes);
        }

        public ActionResult Detials(int id)
        {
            var mes = db.ywshow.Single(x => x.ID == id);
            return View(mes);
        }


    }
}
