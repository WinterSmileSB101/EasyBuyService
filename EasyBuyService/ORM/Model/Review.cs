using EasyBuyService.ORM.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyBuyService.ORM.Model
{
    [Table("dbo.OrderReview","ID")]
    public class Review
    {
        [Field("ID", "int", 0)]
        public int ID { get; set; }

        [Field("ReviewID", "varchar", 20)]
        public string ReviewID { get; set; }

        [Field("OrderIDOrProductID", "varchar", 20)]
        public string OrderIDOrProductID { get; set; }

        [Field("UserID", "varchar", 200)]
        public string UserID { get; set; }

        [Field("Content", "nvarchar", 9999)]
        public string Content { get; set; }

        [Field("CheckPassed", "bit", 0)]
        public bool CheckPassed { get; set; }

        [Field("Score", "int", 0)]
        public int Score { get; set; }

        [Field("ImageName", "varchar", 9999)]
        public string ImageName { get; set; }

        [Field("ImagePosition", "int", 0)]
        public int ImagePosition { get; set; }

        [Field("VoteCount", "int", 0)]
        public int VoteCount { get; set; }

        [Field("VoteUsers", "varchar", 9999)]
        public string VoteUsers { get; set; }
    }
}