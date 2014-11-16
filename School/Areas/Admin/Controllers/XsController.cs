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
    public class XsController : Controller
    {
        //
        // GET: /Admin/Activity/
        private school2014Entities cc = new school2014Entities();
        public ActionResult Index()
        {
            List<ActivitySet> model = cc.Activity.OrderByDescending(x => x.ID).ToList();
            return View(model);
        }
        public ActionResult Details(int id)
        {
            ActivitySet model = cc.Activity.Single(x => x.ID == id);
            return View(model);
        }
        public ActionResult Delete(int id)
        {
            ActivitySet news = cc.Activity.Single(m => m.ID == id);
            return View(news);

        }
        [HttpPost, ActionName("Delete")]

        public ActionResult DeleteConfirmed(int id)
        {
            ActivitySet model = cc.Activity.Single(x => x.ID == id);
            cc.Activity.DeleteObject(model);
            cc.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Creat()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Creat(ActivitySet newSub)
        {
            if (ModelState.IsValid)
            {
                cc.Activity.AddObject(newSub);
                cc.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(newSub);
            }
        }
        public ActionResult Edit(int id)
        {
            var sub = cc.Activity.Single(x => x.ID == id);
            return View(sub);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(int id, FormCollection collection)
        {

            try
            {
                var sub = cc.Activity.Single(x => x.ID == id);
                UpdateModel(sub);
                cc.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        protected override void Dispose(bool disposing)
        {
            cc.Dispose();
            base.Dispose(disposing);
        }
    }
}
