﻿using EasyBuyService.ORM.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyBuyService.ORM.Model
{
    [Table("dbo.ProductAttribute","ID")]
    public class ProductAttribute:BaseModel
    {
        [Field("ID", "int", 0)]
        public int ID { get; set; }

        [Field("AttributeID", "varchar", 20)]
        public int AttributeID { get; set; }

        [Field("ProductID", "varchar", 20)]
        public int ProductID { get; set; }

        [Field("AttributeValue", "nvarchar", 500)]
        public int AttributeValue { get; set; }
    }
}