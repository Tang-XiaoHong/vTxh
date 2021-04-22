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
        public ActionResult submit(string userName, string password, string sex, string introduction, string province)
        {
            TempData["userName"] = userName;
            TempData["password"] = password;
            TempData["sex"] = sex;
            TempData["introduction"] = introduction;
            TempData["province"] = province;
            if (Request.Files.Count == 0)
            {
                TempData["msg"] = "无效文件";
                return RedirectToAction("show");
            }
            var file = Request.Files[0];
            string savePath = Server.MapPath("~/upload/");
            file.SaveAs(savePath + file.FileName);
            TempData["img"] = "/upload/" + file.FileName;
            return RedirectToAction("show");
        }

        public ActionResult show()
        {
            return View();
        }

    }
}