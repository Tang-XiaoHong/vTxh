using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db.view
{
    public class bs_Empl
    {
        public string emplCode { get; set; }
        public string emplName { get; set; }
        public string deptCode { get; set; }

        public int pageIndex { get; set; }
        public int pageSize { get; set; }
        public int rowCount { get; set; }
        public IEnumerable<db.bs_Empl> showData { get; set; }
        public db.bs_Empl entry { get; set; }

        public void search()
        {
            this.pageSize = 10;
            db.dbEntities dc = new db.dbEntities();
            var data = from a in dc.bs_Empl select a;
            if (emplCode != null)
                data = from a in data where a.emplCode.Contains(emplCode) select a;
            if (emplName != null)
                data = from a in data where a.emplName.Contains(emplName) select a;
            if (deptCode != null)
                data = from a in data where a.deptCode == deptCode select a;
            this.rowCount = data.Count();
            data = (from a in data orderby a.rowID ascending select a).Skip(pageIndex * pageSize).Take(pageSize);
            showData = data.ToList<db.bs_Empl>();
        }
    }
}
