using db.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace simpleBookSell.Controllers
{
    public class registerController : Controller
    {
        // GET: view
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult submit(userInfo model,string password,string sex,string province,string city,string introduction)
        {
            if(ModelState.IsValid)
            {
                TempData["userName"] = model.userName;
                TempData["age"] = model.age;
                TempData["identityID"] = model.identityID;
                TempData["telephone"] = model.telephone;
                TempData["email"] = model.email;

                TempData["password"] = password;
                TempData["sex"] = sex;
                TempData["province"] = province;
                TempData["city"] = city;
                TempData["introduction"] = introduction;

                return RedirectToAction("show");
            }
            //if (Request.Files.Count == 0)
            //{
            //    TempData["msg"] = "无效文件";
            //    return RedirectToAction("show");
            //}
            //var file = Request.Files[0];
            //string savePath = Server.MapPath("~/upload/");
            //file.SaveAs(savePath + file.FileName);
            //TempData["img"] = "/upload/" + file.FileName;
            return View(model);
        }
        //[HttpPost]
        //public ActionResult submit(string userName, string password, string sex,int age,string identityID,string telephone,string email,
        //    string introduction, string province,string city)
        //{
        //    TempData["userName"] = userName;
        //    TempData["password"] = password;
        //    TempData["sex"] = sex;
        //    TempData["age"] = age;
        //    TempData["identityID"] = identityID;
        //    TempData["telephone"] = telephone;
        //    TempData["email"] = email;
        //    TempData["introduction"] = introduction;
        //    TempData["province"] = province;
        //    TempData["city"] = city;
        //    //if (Request.Files.Count == 0)
        //    //{
        //    //    TempData["msg"] = "无效文件";
        //    //    return RedirectToAction("show");
        //    //}
        //    //var file = Request.Files[0];
        //    //string savePath = Server.MapPath("~/upload/");
        //    //file.SaveAs(savePath + file.FileName);
        //    //TempData["img"] = "/upload/" + file.FileName;
        //    return RedirectToAction("show");
        //}

        public ActionResult About()
        {
            return View("About");
        }
        public ActionResult show()
        {
            return View();
        }

    }
}