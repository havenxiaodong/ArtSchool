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
    public class SubController : Controller
    {
        //
        // GET: /Admin/Subject/
        private school2014Entities mm = new school2014Entities();
        public ActionResult Index()
        {
            List<SubjectSet> model = mm.Subject.OrderByDescending(x => x.ID).Take(10).ToList();   
            return View(model);
        }
        public ActionResult Details(int id)
        {
            SubjectSet model = mm.Subject.Single(x => x.ID == id);
            return View(model);
        }
        public ActionResult Delete(int id)
        {
            SubjectSet news = mm.Subject.Single(m => m.ID == id);
            return View(news);
            
        }
        [HttpPost,ActionName("Delete")]

        public ActionResult DeleteConfirmed(int id)
        {
            SubjectSet model = mm.Subject.Single(x => x.ID == id);
            mm.Subject.DeleteObject(model);
            mm.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Creat()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Creat(SubjectSet newSub)
        {
            if (ModelState.IsValid)
            {
                mm.Subject.AddObject(newSub);
                mm.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(newSub);
            }
        }
        public ActionResult Edit(int id)
        {
            var sub = mm.Subject.Single(x => x.ID == id);
            return View(sub);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(int id, FormCollection collection)
        {

            try
            {
                var sub = mm.Subject.Single(x => x.ID == id);
                UpdateModel(sub);
                mm.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        protected override void Dispose(bool disposing)
        {
            mm.Dispose();
            base.Dispose(disposing);
        }
    }
}
