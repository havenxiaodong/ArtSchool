using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using School.Models;
using Webdiyer;
using Webdiyer.WebControls.Mvc;
namespace School.Areas.Admin.Controllers
{
    [Authorize]
    public class ImgController : Controller
    {
        private school2014Entities cc = new school2014Entities();
        public ActionResult Index()
        {
                List<ImgBboxSet> model = cc.ImgBbox.OrderByDescending(x => x.ID).ToList();
                return View(model);
        }
        public ActionResult Delete(int id)
        {
                ImgBboxSet news = cc.ImgBbox.Single(m => m.ID == id);
                return View(news);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ImgBboxSet model = cc.ImgBbox.Single(x => x.ID == id);
            cc.ImgBbox.DeleteObject(model);
            cc.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Create()
        {
                return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(ImgBboxSet newSub)
        {
            

                if (ModelState.IsValid)
                {
                    cc.ImgBbox.AddObject(newSub);
                    cc.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(newSub);
                }
        }  
        protected override void Dispose(bool disposing)
        {
            cc.Dispose();
            base.Dispose(disposing);
        }
    }
}
