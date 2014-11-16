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
    public class TxgzController : Controller
    {
        //
        // GET: /Admin/txwork/
        private school2014Entities ff = new school2014Entities();
        public ActionResult Index()
        {
            List<txworkSet> model = ff.txwork.OrderByDescending(x => x.ID).ToList();
            return View(model);
        }
        public ActionResult Details(int id)
        {
            txworkSet model = ff.txwork.Single(x => x.ID == id);
            return View(model);
        }
        public ActionResult Delete(int id)
        {
            txworkSet news = ff.txwork.Single(m => m.ID == id);
            return View(news);

        }
        [HttpPost, ActionName("Delete")]

        public ActionResult DeleteConfirmed(int id)
        {
            txworkSet model = ff.txwork.Single(x => x.ID == id);
            ff.txwork.DeleteObject(model);
            ff.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Creat()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Creat(txworkSet newSub)
        {
            if (ModelState.IsValid)
            {
                ff.txwork.AddObject(newSub);
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
            var sub = ff.txwork.Single(x => x.ID == id);
            return View(sub);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(int id, FormCollection collection)
        {

            try
            {
                var sub = ff.txwork.Single(x => x.ID == id);
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
