using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using School.Models;
namespace School.Areas.Admin.Controllers
{
    
    public class AccountController : Controller
    {
        private school2014Entities db = new school2014Entities();
        public ActionResult LogOn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogOn(LogOnModel model, string returnUrl)
        {
            
            if (ModelState.IsValid)
            {
                if (ValidateUser(model.UserName, model.Password,model.Role))
                {
                    Session["userrole"] = model.Role; 
                    FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                    if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                        && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                        {
                        return Redirect(returnUrl);
                        }
                        
                    else if(model.Role=="teacher")
                        {
                            return RedirectToAction("Index_Unchecked", "News");
                        }
                        else if(model.Role=="student")
                        {
                            return RedirectToAction("Index", "News");
                        }
                }
                else
                {
                    return Content("<script>alert('密码错误！！！');</script>");
                    //ModelState.AddModelError("提供的用户名或密码不正确", "提供的用户名或密码不正确。");
                }
            }

            // 如果我们进行到这一步时某个地方出错，则重新显示表单
            return View(model);
        }
        public bool ValidateUser(string UserName, string PassWord,String Role)
        {
            var user = db.Admin.FirstOrDefault(x => x.Name == UserName && x.PassWord == PassWord &&x.Role==Role);
            if (user != null)
            {
            
                return true;
            }
            else
            {
                return false;
            }
        }
        [Authorize]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("LogOn", "Account");
        }
         [Authorize]
        public ActionResult Register()
        {
            String role = Convert.ToString(Session["userrole"]);
            if (role == "teacher")
                return View();
            else
                return RedirectToAction("error");
        }
       
        [HttpPost]
        public ActionResult Register(AdminSet model)
        {
            if (ModelState.IsValid)
            {
                db.Admin.AddObject(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
            }
        [Authorize]
        public ActionResult Delete(int id)
        {
            AdminSet news = db.Admin.Single(m => m.ID == id);
            return View(news);

        }
        [HttpPost, ActionName("Delete")]

        public ActionResult DeleteConfirmed(int id)
        {
            AdminSet model = db.Admin.Single(x => x.ID == id);
            db.Admin.DeleteObject(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult Index()
        {
            String role = Convert.ToString(Session["userrole"]);
            if (role == "teacher")
            {
                List<AdminSet> model = db.Admin.OrderByDescending(x => x.ID).ToList();
                return View(model);
            }
            else
                return RedirectToAction("error");
        }
       
        public ActionResult Error()
        {
            
            return View();
        }
            
        }
    }
