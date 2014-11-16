using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using School.Models;
using System.Data.Entity;
using System.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Security;
using System.Web.SessionState;
namespace School.Areas.Admin.Controllers
{
    [Authorize]
    public class jingpinController : Controller
    {    
        private school2014Entities hh = new school2014Entities();
        public ViewResult Index()
        {
            List<jingpinSet> model = hh.jingpin.OrderByDescending(x => x.time).ToList();
            return View(model);
        }
        public ViewResult Details(int id)
        {
            jingpinSet news = hh.jingpin.Single(m => m.ID == id);
            return View(news);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(jingpinSet newMovie)
        {
            if (ModelState.IsValid)
            {

                ViewBag.Date = DateTime.Now.ToLocalTime();
                hh.jingpin.AddObject(newMovie);
                hh.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(newMovie);
            }
        }
        public ActionResult Edit(int id)
        {
            var jingpin = hh.jingpin.Single(m => m.ID == id);//校验编辑内容的ID
            {
                return View(jingpin);
            }
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var message = hh.jingpin.Single(m => m.ID == id);
                UpdateModel(message);
                hh.SaveChanges();
                return RedirectToAction("Index");//返回到列表
            }
            catch
            {
                return View();
            }

        }
        public ActionResult Delete(int id)
        {
            jingpinSet jingpin = hh.jingpin.Single(m => m.ID == id);
            return View(jingpin);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            jingpinSet jingpin = hh.jingpin.Single(m => m.ID == id);
            hh.jingpin.DeleteObject(jingpin);
            hh.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Error()
        {
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            hh.Dispose();
            base.Dispose(disposing);
        }
    }
}