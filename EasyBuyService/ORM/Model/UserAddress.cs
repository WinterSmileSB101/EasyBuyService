using EasyBuyService.ORM.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyBuyService.ORM.Model
{
    [Table("dbo.UserAddress","ID")]
    public class UserAddress
    {
        [Field("ID", "int", 0)]
        public int ID { get; set; }

        [Field("UserID", "int", 0)]
        public int UserID { get; set; }

        [Field("CustomerName", "nvarchar", 50)]
        public int CustomerName { get; set; }

        [Field("CustomerPhone", "char", 11)]
        public int CustomerPhone { get; set; }

        [Field("CustomerPostCode", "varchar", 10)]
        public int CustomerPostCode { get; set; }

        [Field("Province", "nvarchar", 20)]
        public int Province { get; set; }

        [Field("City", "nvarchar", 20)]
        public int City { get; set; }

        [Field("Country", "nvarchar", 20)]
        public int Country { get; set; }

        [Field("Town", "nvarchar", 20)]
        public int Town { get; set; }

        [Field("Village", "nvarchar", 20)]
        public int Village { get; set; }

        [Field("DetaileAddress", "nvarchar", 500)]
        public int DetaileAddress { get; set; }

        [Field("Tags", "nvarchar", 99999)]
        public int Tags { get; set; }
    }
}