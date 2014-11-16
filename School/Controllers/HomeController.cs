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
    public class HomeController : Controller
    {
        private school2014Entities a=new school2014Entities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult school_intro()
        {
            return View();
        }
        public ActionResult school_history()
        {
            return View();
        }
        public ActionResult school_nowleader()
        {
            return View();
        }
        public ActionResult leaderbox()
        {
            return View();
        }
        public ActionResult workguide()
        {
            return View();
        }
        public PartialViewResult _NewsList(int NewsIndex = 1)
        {
            List<NewsSet> model =a.News.OrderByDescending(x=>x.Date).Where(x=>x.Checked=="已通过审核").Take(8).ToList();
            return PartialView(model);
        }
        public PartialViewResult _NoticeList(int NoticeIndex = 1)
        {
            List<NoticesSet> model = a.Notices.OrderByDescending(x => x.Date).Take(7).ToList();
            return PartialView(model);
        }
        public PartialViewResult _ActivityList(int ActivityIndex = 1)
        {
            List<ActivitySet> model = a.Activity.OrderByDescending(x => x.Date).Take(7).ToList();
            return PartialView(model);
        }
        public PartialViewResult _TszhList(int TszhIndex = 1)
        {
            List<TszhSet> model = a.Tszh.OrderByDescending(x => x.Time).Take(7).ToList();
            return PartialView(model);
        }
        public PartialViewResult _ImgBox(int ImgBoxIndex = 1)
        {
            List<ImgBboxSet> model = a.ImgBbox.OrderByDescending(x => x.ID).Take(5).ToList();
            return PartialView(model);
        }
        public ActionResult Detials(int id)
        {
            var mes = a.News.Single(x => x.ID == id);
            mes.hit = mes.hit + 1;
            a.SaveChanges();  
            return View(mes);
        }
        public ActionResult NoticeDetials(int id)
        {
            var mes = a.Notices.Single(x => x.ID == id);
            return View(mes);
        }
        public ActionResult TszhDetials(int id)
        {
            var mes = a.Tszh.Single(x => x.ID == id);
            return View(mes);
        }
        public ActionResult ActivityDetails(int id)
        {
            var mes = a.Activity.Single(x => x.ID == id);
            return View(mes);
        }
    }
}
