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
    public class ywshowController : Controller
    {
        //
        // GET: /Admin/ywshow/
        private school2014Entities yy = new school2014Entities();
        public ActionResult Index()
        {
            List<ywshowSet> model = yy.ywshow.OrderByDescending(x => x.ID).ToList();
            return View(model);
        }
        public ActionResult Details(int id)
        {
            ywshowSet model = yy.ywshow.Single(x => x.ID == id);
            return View(model);
        }
        public ActionResult Delete(int id)
        {
            ywshowSet news = yy.ywshow.Single(m => m.ID == id);
            return View(news);

        }
        [HttpPost, ActionName("Delete")]

        public ActionResult DeleteConfirmed(int id)
        {
            ywshowSet model = yy.ywshow.Single(x => x.ID == id);
            yy.ywshow.DeleteObject(model);
            yy.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Creat()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Creat(ywshowSet newSub)
        {
            if (ModelState.IsValid)
            {
                yy.ywshow.AddObject(newSub);
                yy.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(newSub);
            }
        }
        public ActionResult Edit(int id)
        {
            var sub = yy.ywshow.Single(x => x.ID == id);
            return View(sub);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(int id, FormCollection collection)
        {

            try
            {
                var sub = yy.ywshow.Single(x => x.ID == id);
                UpdateModel(sub);
                yy.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        protected override void Dispose(bool disposing)
        {
            yy.Dispose();
            base.Dispose(disposing);
        }
    }
}
