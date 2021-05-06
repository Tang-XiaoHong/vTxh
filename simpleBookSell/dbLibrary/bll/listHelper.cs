using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace db.bll
{
    public class listHelper
    {
        public static List<SelectListItem> getTestProvince()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem() { Text = "北京", Value = "bj", Selected = true });
            list.Add(new SelectListItem() { Text = "天津", Value = "tj" });
            list.Add(new SelectListItem() { Text = "重庆", Value = "cq" });
            list.Add(new SelectListItem() { Text = "江苏", Value = "js" });
            list.Add(new SelectListItem() { Text = "四川", Value = "sc" });
            return list;
        }
        public static List<SelectListItem> getTestCity()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            if (true)
            {
                list.Add(new SelectListItem() { Text = "南京", Value = "nj", Selected = true });
                list.Add(new SelectListItem() { Text = "苏州", Value = "sz" });
                list.Add(new SelectListItem() { Text = "镇江", Value = "zj" });
                list.Add(new SelectListItem() { Text = "镇江", Value = "zj" });
            }
            return list;
        }
        public static List<SelectListItem> getSex()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem() { Text = "男", Value = "Male", Selected = true });
            list.Add(new SelectListItem() { Text = "女", Value = "Female" });
            return list;
        }
        public static List<SelectListItem> getHobby()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem() { Text = "阅读", Value = "read" });
            list.Add(new SelectListItem() { Text = "唱歌", Value = "sing" });
            list.Add(new SelectListItem() { Text = "跑步", Value = "jog" });
            return list;
        }
        public static List<SelectListItem> getBookTypes()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem() { Text = "计算机", Value = "computer" });
            list.Add(new SelectListItem() { Text = "文学", Value = "literature" });
            list.Add(new SelectListItem() { Text = "地理", Value = "geography" });

            return list;
        }
        public static List<SelectListItem> getBookTags()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem() { Text = "促销", Value = "sale" });
            list.Add(new SelectListItem() { Text = "畅销", Value = "best" });
            list.Add(new SelectListItem() { Text = "清仓", Value = "clear" });

            return list;
        }
        public static List<SelectListItem> getBookTags(string oldValue)
        {
            if (oldValue == null)
            {
                oldValue = "";
            }

            List<string> selectedList = oldValue.Split(',').ToList<string>();

            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem() { Text = "促销", Value = "sale" });
            list.Add(new SelectListItem() { Text = "畅销", Value = "best" });
            list.Add(new SelectListItem() { Text = "清仓", Value = "clear" });

            foreach (var item in list)
            {
                if (selectedList.Contains(item.Value))
                    item.Selected = true;
            }
            return list;
        }

    }
}
