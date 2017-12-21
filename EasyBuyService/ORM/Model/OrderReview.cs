using EasyBuyService.ORM.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyBuyService.ORM.Model
{
    [Table("dbo.OrderReview","ID")]
    public class OrderReview
    {
        [Field("ID", "int", 0)]
        public int ID { get; set; }

        [Field("OrderID", "varchar", 20)]
        public int OrderID { get; set; }

        [Field("Content", "nvarchar", 9999)]
        public int Content { get; set; }

        [Field("CheckPassed", "bit", 0)]
        public int CheckPassed { get; set; }

        [Field("Score", "int", 0)]
        public int Score { get; set; }

        [Field("ImageName", "varchar", 9999)]
        public int ImageName { get; set; }

        [Field("ImagePosition", "int", 0)]
        public int ImagePosition { get; set; }
    }
}