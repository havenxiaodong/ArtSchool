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
using Webdiyer;
using Webdiyer.WebControls.Mvc;
namespace School.Controllers
{
    public class NewsListController : Controller
    {
        //
        // GET: /NewsList/
        private school2014Entities a = new school2014Entities();
        public ViewResult Index(int news=1)
        {
            PagedList<NewsSet> model = a.News.OrderByDescending(x => x.Date).Where(x=>x.Checked=="已通过审核").ToPagedList(news, 12);

            return View(model);
        }
        public ViewResult Details(int id)
        {
            NewsSet news = a.News.Single(m => m.ID == id);
            news.hit = news.hit + 1;
            a.SaveChanges();    
            return View(news);
        }

    }
}
