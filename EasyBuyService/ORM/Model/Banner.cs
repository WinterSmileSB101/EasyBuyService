using EasyBuyService.ORM.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyBuyService.ORM.Model
{
    [Table("dbo.Banner","ID")]
    public class Banner:BaseModel
    {
        [Field("ID", "int", 0)]
        public int ID { get; set; }

        [Field("Link", "nvarchar", 100)]
        public int Link { get; set; }

        [Field("ImageUrl", "nvarchar", 100)]
        public int ImageUrl { get; set; }

        [Field("StartTime", "datetime", 0)]
        public int StartTime { get; set; }

        [Field("ExprieTime", "datetime", 0)]
        public int ExprieTime { get; set; }

        [Field("BriefDescription", "nvarchar", 50)]
        public int BriefDescription { get; set; }
    }
}