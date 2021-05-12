using simpleBookSell.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace simpleBookSell.Controllers
{
    public class bookController : Controller
    {
        // GET: book
        // 首页展示图书列表
        [author]
        //[OutputCache(CacheProfile = "mySqlCache")]
        public ActionResult bookList()
        {
            List<db.Books> list = db.bll.books.getBooks();
            return View(list);
        }

        [HttpPost]
        public ActionResult bookList(string str)
        {
            string bookId = Request["detail.BookId"].ToString();
            string price = Request["detail.price"].ToString();

            List<string> bookIdList = bookId.Split(',').ToList<string>();
            List<string> priceList = price.Split(',').ToList<string>();
            Dictionary<string, string> dicTags = new Dictionary<string, string>();
            Dictionary<string, string> dicType = new Dictionary<string, string>();
            foreach (var item in bookIdList)
            {
                string bookTag = (Request["detail.BookTag." + item] == null) ?
                    "" : Request["detail.BookTag." + item].ToString();
                string bookType = (Request["detail.BookType." + item] == null) ?
                    "" : Request["detail.BookType." + item].ToString();
                dicTags.Add(item, bookTag);
                dicType.Add(item, bookType);
            }
            db.bll.books.batchUpdate(bookIdList, priceList, dicTags, dicType);
            return RedirectToAction("bookList");
        }

        //图书详情
        public ActionResult Detail(int id)
        {
            db.Books entry = db.bll.books.getEntry(id);
            return View(entry);
        }

        //图书新增界面展示
        [HttpGet]
        public ActionResult insert()
        {
            db.Books entry = new db.Books();
            return View(entry);
        }

        //保存新增图书数据
        [HttpPost]
        public ActionResult insert(string AuthorName, string Title, Nullable<decimal> Price)
        {
            db.bll.books.insert(AuthorName, Title, Price);
            return RedirectToAction("bookList");
        }

        //图书新增界面展示-方法2
        [HttpGet]
        public ActionResult insertEntry()
        {
            db.Books entry = new db.Books();
            return View(entry);
        }

        //保存新增图书数据-方法2
        [HttpPost]
        public ActionResult insertEntry(db.Books entry)
        {
            //视图中需要特殊处理的数据（多选和文件）
            if (Request["BookTag"] != null)
            {
                entry.BookTag = Request["BookTag"].ToString();
            }
            if (Request.Files.Count > 0 && Request.Files[0].FileName != "")
            {
                string savePath = "/upload/"
                    + DateTime.Now.ToString("yyyyMMddhhmmss")
                    + Request.Files[0].FileName;
                Request.Files[0].SaveAs(Server.MapPath(savePath));
                entry.BookCoverUrl = savePath;
            }

            db.bll.books.insert(entry);
            return RedirectToAction("bookList");
        }

        //图书修改界面展示
        [HttpGet]
        public ActionResult update(int id)
        {
            db.Books entry = db.bll.books.getEntry(id);
            return View(entry);
        }

        //保存修改图书数据
        [HttpPost]
        public ActionResult update(int BookId, string AuthorName, string Title, Nullable<decimal> Price)
        {
            db.bll.books.update(BookId, AuthorName, Title, Price);
            return RedirectToAction("bookList");
        }

        //图书修改界面展示-方法2
        [HttpGet]
        public ActionResult updateEntry(int id)
        {
            db.Books entry = db.bll.books.getEntry(id);
            return View(entry);
        }

        //保存修改图书数据-方法2
        [HttpPost]
        public ActionResult updateEntry(db.Books entry)
        {
            db.bll.books.update(entry);
            return RedirectToAction("bookList");
        }

        //图书修改界面展示-方法3
        [HttpGet]
        public ActionResult update3(int id)
        {
            db.Books entry = db.bll.books.getEntry(id);
            return View(entry);
        }

        //保存修改图书数据-方法3
        [HttpPost]
        public ActionResult update3(db.Books entry)
        {
            //视图中需要特殊处理的数据(多选和文件)
            if (Request["BookTag"] != null)
            {
                entry.BookTag = Request["BookTag"].ToString();
            }
            if (Request.Files.Count > 0 && Request.Files[0].FileName != "")
            {
                string savePath = "/upload/"
                    + DateTime.Now.ToString("yyyyMMddhhmmss")
                    + Request.Files[0].FileName;
                Request.Files[0].SaveAs(Server.MapPath(savePath));
                entry.BookCoverUrl = savePath;
            }

            db.bll.books.update3(entry);
            return RedirectToAction("bookList");
        }

        //图书删除
        public ActionResult delete(int id)
        {
            db.bll.books.Delete(id);
            return RedirectToAction("bookList");
        }

    }
}