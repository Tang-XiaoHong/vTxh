using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace simpleBookSell.Controllers
{
    public class bs_EmplController : Controller
    {
        // GET: bs_Empl
        public ActionResult Index(db.view.bs_Empl model)
        {
            model.search();
            return View(model);
        }
        
    }
}