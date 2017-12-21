using EasyBuyService.ORM.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyBuyService.ORM.Model
{
    [Table("dbo.Product","ID")]
    public class Product:BaseModel
    {
        [Field("ID", "int", 0)]
        public int ID { get; set; }

        [Field("ProductID", "varchar", 20)]
        public int ProductID { get; set; }

        [Field("ProductName", "nvarchar", 50)]
        public int ProductName { get; set; }

        [Field("ImageUrl", "nvarchar", 100)]
        public int ImageUrl { get; set; }

        [Field("ImageName", "varchar", 9999)]
        public int ImageName { get; set; }

        [Field("ImagePosition", "int", 0)]
        public int ImagePosition { get; set; }

        [Field("Stock", "int", 0)]
        public int Stock { get; set; }

        [Field("ItemType", "int", 0)]
        public int ItemType { get; set; }

        [Field("CategoryID", "varchar", 20)]
        public int CategoryID { get; set; }

        [Field("IsPublish", "bit", 0)]
        public int IsPublish { get; set; }

        [Field("Priority", "int", 0)]
        public int Priority { get; set; }

        [Field("Description", "nvarchar", 100)]
        public int Description { get; set; }

        [Field("DetailDescription", "nvarchar", 9999)]
        public int DetailDescription { get; set; }

        [Field("OriginalPrice", "int", 0)]
        public int OriginalPrice { get; set; }

        [Field("Discount", "int", 0)]
        public int Discount { get; set; }
    }
}