using EasyBuyService.ORM.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyBuyService.ORM.Model
{
    [Table("dbo.Order", "ID")]
    public class Order: BaseModel
    {
        [Field("ID", "int", 0)]
        public int ID { get; set; }

        [Field("OrderID", "varchar", 20)]
        public string OrderID { get; set; }

        [Field("OrderState", "int", 0)]
        public int OrderState { get; set; }

        [Field("CostomerID", "varchar", 200)]
        public string CostomerID { get; set; }

        [Field("OrderTotal", "int", 0)]
        public int OrderTotal { get; set; }

        [Field("Discount", "int", 0)]
        public int Discount { get; set; }

        [Field("PayCostomerID", "varchar", 200)]
        public string PayCostomerID { get; set; }

        [Field("Comment", "nvarchar", 9999)]
        public string Comment { get; set; }
    }
}