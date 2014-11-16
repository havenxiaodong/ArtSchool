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
    public class xueshuController : Controller
    {
        //
        // GET: /NoticesList/
        private school2014Entities aa = new school2014Entities();
        public ViewResult Index(int Notice = 1)
        {
            PagedList<ActivitySet> model = aa.Activity.OrderByDescending(x => x.Date).ToPagedList(Notice, 12);

            return View(model);
        }
        public ViewResult Details(int id)
        {
            ActivitySet Notice = aa.Activity.Single(m => m.ID == id);
            return View(Notice);
        }

    }
}
