﻿using System.Data.Common;
using System.Data.Entity;

namespace db
{
    public partial class dbEntities : DbContext
    {
        //保存当前启用的事务对象
        public DbTransaction efTran { get; set; }
        private DbConnection _efconn;

        //获取所用的连接对象
        public DbConnection efConn
        {
            get
            {
                if (_efconn == null)
                    _efconn = this.Database.Connection;
                return _efconn;
            }
        }

    }
}
