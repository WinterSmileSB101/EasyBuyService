using EasyBuyService.ORM.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyBuyService.ORM.Model
{
    [Table("dbo.ShoppingCart","ID")]
    public class ShoppingCart:BaseModel
    {
        [Field("ID", "int", 0)]
        public int ID { get; set; }

        [Field("AttributeID", "varchar", 20)]
        public int AttributeID { get; set; }

        [Field("ProductID", "varchar", 20)]
        public int ProductID { get; set; }

        [Field("AttributeValue", "nvarchar", 500)]
        public int AttributeValue { get; set; }

        [Field("UserID", "varchar", 200)]
        public int UserID { get; set; }

        [Field("ProductNumber", "int", 0)]
        public int ProductNumber { get; set; }

        [Field("VendorID", "varchar", 200)]
        public int VendorID { get; set; }
    }
}