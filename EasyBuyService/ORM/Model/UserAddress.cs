using EasyBuyService.ORM.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyBuyService.ORM.Model
{
    [Table("dbo.UserAddress","ID")]
    public class UserAddress: BaseModel
    {
        [Field("ID", "int", 0)]
        public int ID { get; set; }

        [Field("UserID", "varchar", 200)]
        public string UserID { get; set; }

        [Field("CustomerName", "nvarchar", 50)]
        public string CustomerName { get; set; }

        [Field("CustomerPhone", "char", 11)]
        public string CustomerPhone { get; set; }

        [Field("CustomerPostCode", "varchar", 10)]
        public string CustomerPostCode { get; set; }

        [Field("Province", "nvarchar", 20)]
        public string Province { get; set; }

        [Field("City", "nvarchar", 20)]
        public string City { get; set; }

        [Field("Country", "nvarchar", 20)]
        public string Country { get; set; }

        [Field("Town", "nvarchar", 20)]
        public string Town { get; set; }

        [Field("Village", "nvarchar", 20)]
        public string Village { get; set; }

        [Field("DetaileAddress", "nvarchar", 500)]
        public string DetaileAddress { get; set; }

        [Field("Tags", "nvarchar", 99999)]
        public string Tags { get; set; }
    }
}