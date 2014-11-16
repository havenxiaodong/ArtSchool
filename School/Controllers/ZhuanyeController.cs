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
    public class ZhuanyeController : Controller
    {
        //
        // GET: /zhuanye/
        private school2014Entities xx = new school2014Entities();
        public PartialViewResult _Index1(int jwIndex = 1)
        {
            PagedList<zhuanyeSet> sub = xx.zhuanye.OrderByDescending(x => x.time).Where(x => x.kind == "教学团队").ToPagedList(jwIndex, 7);
            return PartialView(sub);
        }
        public PartialViewResult _Index2(int jwIndex = 1)
        {
            PagedList<zhuanyeSet> sub = xx.zhuanye.OrderByDescending(x => x.time).Where(x => x.kind == "专业介绍").ToPagedList(jwIndex, 7);
            return PartialView(sub);
        }
        public PartialViewResult _Index3(int jwIndex = 1)
        {
            PagedList<zhuanyeSet> sub = xx.zhuanye.OrderByDescending(x => x.time).Where(x => x.kind == "培养方案").ToPagedList(jwIndex, 7);
            return PartialView(sub);
        }
        public PartialViewResult _Index4(int jwIndex = 1)
        {
            PagedList<zhuanyeSet> sub = xx.zhuanye.OrderByDescending(x => x.time).Where(x => x.kind == "特色专业").ToPagedList(jwIndex, 7);
            return PartialView(sub);
        }
        public ActionResult Detials(int id)
        {
            var mes = xx.zhuanye.Single(x => x.ID == id);
            return View(mes);
        }
    }
}
