using EasyBuyService.ORM.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyBuyService.ORM.Model
{
    [Table("dbo.Category","ID")]
    public class Category:BaseModel
    {
        [Field("ID", "int", 0)]
        public int ID { get; set; }

        [Field("CategoryID", "varchar", 20)]
        public int CategoryID { get; set; }

        [Field("Enable", "bit", 0)]
        public int Enable { get; set; }

        [Field("CategoryName", "nvarchar", 30)]
        public int CategoryName { get; set; }

        [Field("CategoryDescription", "nvarchar", 500)]
        public int CategoryDescription { get; set; }

        [Field("ParentCategoryID", "varchar", 20)]
        public int ParentCategoryID { get; set; }
    }
}