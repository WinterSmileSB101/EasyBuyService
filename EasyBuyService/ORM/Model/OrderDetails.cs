using EasyBuyService.ORM.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyBuyService.ORM.Model
{
    [Table("dbo.OrderDetails","ID")]
    public class OrderDetails: BaseModel
    {
        [Field("ID", "int", 0)]
        public int ID { get; set; }

        [Field("OrderID", "varchar", 20)]
        public int OrderID { get; set; }

        [Field("ProductID", "varchar", 20)]
        public int ProductID { get; set; }
    }
}