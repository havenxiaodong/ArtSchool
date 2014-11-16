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
    public class ZhuantiController : Controller
    {
        //
        // GET: /Yyfc/
        private school2014Entities db = new school2014Entities();
        public ActionResult Index(int NewMes = 1)
        {
            PagedList<ztmangerSet> mes = db.ztmanger.OrderByDescending(x => x.time).ToPagedList(NewMes, 7);

            return View(mes);
        }
        public ActionResult Detials(int id)
        {
            var mes = db.ztmanger.Single(x => x.ID == id);
            return View(mes);
        }


    }
}
