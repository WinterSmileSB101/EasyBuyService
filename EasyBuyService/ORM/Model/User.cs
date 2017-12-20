using EasyBuyService.ORM.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyBuyService.ORM.Model
{
    [Table("dbo.User","UserID")]
    public class User
    {
        [Field("UserID","int",0)]
        public int UserID { get; set; }

        [Field("UserName", "nvarchar", 50)]
        public int UserName { get; set; }

        [Field("UserPassWord", "varchar", 50)]
        public int UserPassWord { get; set; }

        [Field("Email", "varchar", 50)]
        public int Email { get; set; }

        [Field("Phone", "char", 11)]
        public int Phone { get; set; }

        [Field("Role", "char", 5)]
        public int Role { get; set; }
    }
}