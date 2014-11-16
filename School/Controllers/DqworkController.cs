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
    public class DqworkController : Controller
    {
        //
        // GET: /dqwork/
        private school2014Entities xx = new school2014Entities();
        public PartialViewResult _Index1(int jwIndex = 1)
        {
            PagedList<dqworkSet> sub = xx.dqwork.OrderByDescending(x => x.time).Where(x => x.kind == "理论学习").ToPagedList(jwIndex, 7);
            return PartialView(sub);
        }
        public PartialViewResult _Index2(int jwIndex = 1)
        {
            PagedList<dqworkSet> sub = xx.dqwork.OrderByDescending(x => x.time).Where(x => x.kind == "组织机构").ToPagedList(jwIndex, 7);
            return PartialView(sub);
        }
        public PartialViewResult _Index3(int jwIndex = 1)
        {
            PagedList<dqworkSet> sub = xx.dqwork.OrderByDescending(x => x.time).Where(x => x.kind == "制度建设").ToPagedList(jwIndex, 7);
            return PartialView(sub);
        }
        public PartialViewResult _Index4(int jwIndex = 1)
        {
            PagedList<dqworkSet> sub = xx.dqwork.OrderByDescending(x => x.time).Where(x => x.kind == "党群动态").ToPagedList(jwIndex, 7);
            return PartialView(sub);
        }
        public PartialViewResult _Index5(int jwIndex = 1)
        {
            PagedList<dqworkSet> sub = xx.dqwork.OrderByDescending(x => x.time).Where(x => x.kind == "学院党校").ToPagedList(jwIndex, 7);
            return PartialView(sub);
        }
        public PartialViewResult _Index6(int jwIndex = 1)
        {
            PagedList<dqworkSet> sub = xx.dqwork.OrderByDescending(x => x.time).Where(x => x.kind == "党支部风采").ToPagedList(jwIndex, 7);
            return PartialView(sub);
        }
        public PartialViewResult _Index7(int jwIndex = 1)
        {
            PagedList<dqworkSet> sub = xx.dqwork.OrderByDescending(x => x.time).Where(x => x.kind == "党员风采").ToPagedList(jwIndex, 7);
            return PartialView(sub);
        }
        public PartialViewResult _Index8(int jwIndex = 1)
        {
            PagedList<dqworkSet> sub = xx.dqwork.OrderByDescending(x => x.time).Where(x => x.kind == "党员工作站").ToPagedList(jwIndex, 7);
            return PartialView(sub);
        }
        public PartialViewResult _Index9(int jwIndex = 1)
        {
            PagedList<dqworkSet> sub = xx.dqwork.OrderByDescending(x => x.time).Where(x => x.kind == "工会教代会").ToPagedList(jwIndex, 7);
            return PartialView(sub);
        }
        public PartialViewResult _Index10(int jwIndex = 1)
        {
            PagedList<dqworkSet> sub = xx.dqwork.OrderByDescending(x => x.time).Where(x => x.kind == "妇委会").ToPagedList(jwIndex, 7);
            return PartialView(sub);
        }
        public ActionResult Detials(int id)
        {
            var mes = xx.dqwork.Single(x => x.ID == id);
            return View(mes);
        }
    }
}
