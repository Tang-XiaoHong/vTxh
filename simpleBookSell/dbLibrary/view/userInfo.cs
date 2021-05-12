using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace db.view
{
    public class userInfo
    {
        [Required]
        [MaxLength(10)]
        public string userName { get; set; }
        [Required]
        [Range(16, 25, ErrorMessage = "错误")]
        public int age { get; set; }
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "错误")]
        public string email { get; set; }
        public string identityID { get; set; }
        [Required]
        [System.Web.Mvc.Compare("identityID", ErrorMessage = "错误")]
        public string ConfirmidentityID { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber, ErrorMessage = "错误")]
        public string telephone { get; set; }

    }
}
