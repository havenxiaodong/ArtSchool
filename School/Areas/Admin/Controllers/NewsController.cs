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
    public class NewsController : Controller
    {
        private school2014Entities db = new school2014Entities();
        public ViewResult Index(int news=1)
        {  
            PagedList<NewsSet> model = db.News.OrderByDescending(x => x.Date).ToPagedList(news,25);
            return View(model);
        }
        public ActionResult Index_Unchecked(int news=1)
        {
             String role = Convert.ToString(Session["userrole"]);
             if(role=="teacher")            
             {
                 PagedList<NewsSet> model = db.News.OrderByDescending(x => x.Date).Where(x => x.Checked == null).ToPagedList(news,25);
                  return View(model);
             }
             else
			 {
			      return RedirectToAction("Error");
			 }
            
        }
        public ViewResult Details(int id)
        {
            NewsSet news = db.News.Single(m => m.ID == id);
            return View(news);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(NewsSet newMovie)
        {
            if (ModelState.IsValid)
            {
                
                ViewBag.Date = DateTime.Now.ToLocalTime();
                db.News.AddObject(newMovie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(newMovie);
            }
        }      
        public ActionResult Edit(int id)
        {
            var news = db.News.Single(m => m.ID == id);//校验编辑内容的ID         
            {
                return View(news);
            }
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(int id, FormCollection collection)
        {
                try
                {
                    var message = db.News.Single(m => m.ID == id);
                    UpdateModel(message);
                    db.SaveChanges();
                    return RedirectToAction("Index");//返回到列表
                }
                catch
                {
                    return View();
                }

        }
        public ActionResult Check(int id)
        {
            var news = db.News.Single(m => m.ID == id);
            {
                return View(news);
            }
         }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Check(int id, FormCollection collection)
        {
            try
                {
                    var message = db.News.Single(m => m.ID == id);
                    UpdateModel(message);
                    db.SaveChanges();
                    return RedirectToAction("Index_Unchecked");//返回到列表
                }
                catch
                {
                    return View();
                }
         }    
        public ActionResult Delete(int id)
        {
            NewsSet news = db.News.Single(m => m.ID == id);
            return View(news);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            NewsSet news = db.News.Single(m => m.ID == id);
            db.News.DeleteObject(news);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Error()
        {
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}