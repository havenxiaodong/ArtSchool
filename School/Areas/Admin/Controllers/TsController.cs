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
    public class TsController : Controller
    {
        //
        // GET: /Admin/Tszh/
        private school2014Entities cc = new school2014Entities();
        public ActionResult Index()
        {
            List<TszhSet> model = cc.Tszh.OrderByDescending(x => x.ID).ToList();
            return View(model);
        }
        public ActionResult Details(int id)
        {
            TszhSet model = cc.Tszh.Single(x => x.ID == id);
            return View(model);
        }
        public ActionResult Delete(int id)
        {
            TszhSet news = cc.Tszh.Single(m => m.ID == id);
            return View(news);

        }
        [HttpPost, ActionName("Delete")]

        public ActionResult DeleteConfirmed(int id)
        {
            TszhSet model = cc.Tszh.Single(x => x.ID == id);
            cc.Tszh.DeleteObject(model);
            cc.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Creat()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Creat(TszhSet newSub)
        {
            if (ModelState.IsValid)
            {
                cc.Tszh.AddObject(newSub);
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
            var sub = cc.Tszh.Single(x => x.ID == id);
            return View(sub);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(int id, FormCollection collection)
        {

            try
            {
                var sub = cc.Tszh.Single(x => x.ID == id);
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
