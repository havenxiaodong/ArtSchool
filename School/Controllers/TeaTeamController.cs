using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using School.Models;
using Webdiyer;
using Webdiyer.WebControls.Mvc;

namespace School.Controllers
    {
    public class TeaTeamController :Controller
        {
        private school2014Entities db = new school2014Entities();
        public ActionResult _TeaList1(int TeaIndex=1)
            {
            PagedList<TeaTeamSet> model = db.TeaTeam.OrderByDescending(x => x.ID).Where(x=>x.kind=="艺术设计").ToPagedList(TeaIndex,15);
            return View(model);
            }
        public ActionResult _TeaList2(int TeaIndex = 1)
        {
            PagedList<TeaTeamSet> model = db.TeaTeam.OrderByDescending(x => x.ID).Where(x => x.kind == "工业设计").ToPagedList(TeaIndex, 15);
            return View(model);
        }
        public ActionResult _TeaList3(int TeaIndex = 1)
        {
            PagedList<TeaTeamSet> model = db.TeaTeam.OrderByDescending(x => x.ID).Where(x => x.kind == "音乐系").ToPagedList(TeaIndex, 15);
            return View(model);
        }
        public ActionResult TeaDetails(int id)
        {
            TeaTeamSet model = db.TeaTeam.Single(x => x.ID == id);
            return View(model);
        }
        }
    }