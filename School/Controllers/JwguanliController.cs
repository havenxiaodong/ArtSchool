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
    public class JwguanliController : Controller
    {
        //
        // GET: /jwmanger/
        private school2014Entities xx = new school2014Entities();
        public PartialViewResult _Index1(int jwIndex = 1)
        {
            PagedList<jwmangerSet> sub = xx.jwmanger.OrderByDescending(x => x.time).Where(x => x.kind == "制度文件").ToPagedList(jwIndex,7);
            return PartialView(sub);
        }
        public PartialViewResult _Index2(int jwIndex = 1)
        {
            PagedList<jwmangerSet> sub = xx.jwmanger.OrderByDescending(x => x.time).Where(x => x.kind == "教务通知").ToPagedList(jwIndex,7);
            return PartialView(sub);
        }
        public PartialViewResult _Index3(int jwIndex = 1)
        {
            PagedList<jwmangerSet> sub = xx.jwmanger.OrderByDescending(x => x.time).Where(x => x.kind == "实践教学").ToPagedList(jwIndex,7);
            return PartialView(sub);
        }
        public PartialViewResult _Index4(int jwIndex = 1)
        {
            PagedList<jwmangerSet> sub = xx.jwmanger.OrderByDescending(x => x.time).Where(x => x.kind == "工作流程").ToPagedList(jwIndex,7);
            return PartialView(sub);
        }
        public ActionResult Details(int id)
        {
            var mes = xx.jwmanger.Single(x => x.ID == id);
            return View(mes);
        }
    }
}
