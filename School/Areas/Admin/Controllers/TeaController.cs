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
    public class TeaController : Controller
    {
        //
        // GET: /Admin/TeaTeam/
        private school2014Entities ww = new school2014Entities();
        public ActionResult Index()
        {
            List<TeaTeamSet> model = ww.TeaTeam.OrderByDescending(x => x.ID).Take(10).ToList();
            return View(model);
        }
        public ActionResult Details(int id)
        {
            TeaTeamSet model = ww.TeaTeam.Single(x => x.ID == id);
            return View(model);
        }
        public ActionResult Delete(int id)
        {
            TeaTeamSet news = ww.TeaTeam.Single(m => m.ID == id);
            return View(news);

        }
        [HttpPost, ActionName("Delete")]

        public ActionResult DeleteConfirmed(int id)
        {
            TeaTeamSet model = ww.TeaTeam.Single(x => x.ID == id);
            ww.TeaTeam.DeleteObject(model);
            ww.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Creat()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Creat(TeaTeamSet newSub)
        {
            if (ModelState.IsValid)
            {
                ww.TeaTeam.AddObject(newSub);
                ww.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(newSub);
            }
        }
        public ActionResult Edit(int id)
        {
            var sub = ww.TeaTeam.Single(x => x.ID == id);
            return View(sub);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(int id, FormCollection collection)
        {

            try
            {
                var sub = ww.TeaTeam.Single(x => x.ID == id);
                UpdateModel(sub);
                ww.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        protected override void Dispose(bool disposing)
        {
            ww.Dispose();
            base.Dispose(disposing);
        }
    }
}
