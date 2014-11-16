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
    public class DqgzController : Controller
    {
        private school2014Entities ff = new school2014Entities();
        public ActionResult Index()
        {
            List<dqworkSet> model = ff.dqwork.OrderByDescending(x => x.ID).ToList();
            return View(model);
        }
        public ActionResult Details(int id)
        {
            dqworkSet model = ff.dqwork.Single(x => x.ID == id);
            return View(model);
        }
        public ActionResult Delete(int id)
        {
            dqworkSet news = ff.dqwork.Single(m => m.ID == id);
            return View(news);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            dqworkSet model = ff.dqwork.Single(x => x.ID == id);
            ff.dqwork.DeleteObject(model);
            ff.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Creat()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Creat(dqworkSet newSub)
        {
            if (ModelState.IsValid)
            {
                ff.dqwork.AddObject(newSub);
                ff.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(newSub);
            }
        }
        public ActionResult Edit(int id)
        {
            var sub = ff.dqwork.Single(x => x.ID == id);
            return View(sub);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(int id, FormCollection collection)
        {

            try
            {
                var sub = ff.dqwork.Single(x => x.ID == id);
                UpdateModel(sub);
                ff.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        protected override void Dispose(bool disposing)
        {
            ff.Dispose();
            base.Dispose(disposing);
        }
    }
}
