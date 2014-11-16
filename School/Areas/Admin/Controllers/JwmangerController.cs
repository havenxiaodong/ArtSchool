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
    public class JwmangerController : Controller
    {
        private school2014Entities yy = new school2014Entities();
        public ActionResult Index()
        {
            List<jwmangerSet> model = yy.jwmanger.OrderByDescending(x => x.ID).ToList();
            return View(model);
        }
        public ActionResult Details(int id)
        {
            jwmangerSet model = yy.jwmanger.Single(x => x.ID == id);
            return View(model);
        }
        public ActionResult Delete(int id)
        {
            jwmangerSet news = yy.jwmanger.Single(m => m.ID == id);
            return View(news);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            jwmangerSet model = yy.jwmanger.Single(x => x.ID == id);
            yy.jwmanger.DeleteObject(model);
            yy.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Creat()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Creat(jwmangerSet newSub)
        {
            if (ModelState.IsValid)
            {
                yy.jwmanger.AddObject(newSub);
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
            var sub = yy.jwmanger.Single(x => x.ID == id);
            return View(sub);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var sub = yy.jwmanger.Single(x => x.ID == id);
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
