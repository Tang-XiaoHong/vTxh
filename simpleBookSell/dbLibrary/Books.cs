//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Books
    {
        public int BookId { get; set; }
        public string AuthorName { get; set; }
        public string Title { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string BookCoverUrl { get; set; }
        public string BookType { get; set; }
        public string BookTag { get; set; }
    }
}
