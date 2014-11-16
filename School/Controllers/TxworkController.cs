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
    public class txworkController : Controller
    {
        //
        // GET: /txwork/
        private school2014Entities ss = new school2014Entities();
        public PartialViewResult _Index1(int jwIndex = 1)
        {
            PagedList<txworkSet> sub = ss.txwork.OrderByDescending(x => x.time).Where(x => x.kind == "思想教育").ToPagedList(jwIndex, 7);
            return PartialView(sub);
        }
        public PartialViewResult _Index2(int jwIndex = 1)
        {
            PagedList<txworkSet> sub = ss.txwork.OrderByDescending(x => x.time).Where(x => x.kind == "学风建设").ToPagedList(jwIndex, 7);
            return PartialView(sub);
        }
        public PartialViewResult _Index3(int jwIndex = 1)
        {
            PagedList<txworkSet> sub = ss.txwork.OrderByDescending(x => x.time).Where(x => x.kind == "日常管理").ToPagedList(jwIndex, 7);
            return PartialView(sub);
        }
        public PartialViewResult _Index4(int jwIndex = 1)
        {
            PagedList<txworkSet> sub = ss.txwork.OrderByDescending(x => x.time).Where(x => x.kind == "奖励工作").ToPagedList(jwIndex, 7);
            return PartialView(sub);
        }
        public PartialViewResult _Index5(int jwIndex = 1)
        {
            PagedList<txworkSet> sub = ss.txwork.OrderByDescending(x => x.time).Where(x => x.kind == "团学活动").ToPagedList(jwIndex, 7);
            return PartialView(sub);
        }
        public PartialViewResult _Index6(int jwIndex = 1)
        {
            PagedList<txworkSet> sub = ss.txwork.OrderByDescending(x => x.time).Where(x => x.kind == "就业工作").ToPagedList(jwIndex, 7);
            return PartialView(sub);
        }
        public PartialViewResult _Index7(int jwIndex = 1)
        {
            PagedList<txworkSet> sub = ss.txwork.OrderByDescending(x => x.time).Where(x => x.kind == "健康教育").ToPagedList(jwIndex, 7);
            return PartialView(sub);
        }
        public PartialViewResult _Index8(int jwIndex = 1)
        {
            PagedList<txworkSet> sub = ss.txwork.OrderByDescending(x => x.time).Where(x => x.kind == "创新创业").ToPagedList(jwIndex, 7);
            return PartialView(sub);
        }
        public PartialViewResult _Index9(int jwIndex = 1)
        {
            PagedList<txworkSet> sub = ss.txwork.OrderByDescending(x => x.time).Where(x => x.kind == "岁月答疑").ToPagedList(jwIndex, 7);
            return PartialView(sub);
        }
        public ActionResult Details(int id)
        {
            var mes = ss.txwork.Single(x => x.ID == id);
            return View(mes);
        }
    }
}
