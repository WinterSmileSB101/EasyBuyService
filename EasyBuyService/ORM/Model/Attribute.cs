﻿using EasyBuyService.ORM.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyBuyService.ORM.Model
{
    [Table("dbo.ProductAttribute","ID")]
    public class Attribute:BaseModel
    {
        [Field("ID", "int", 0)]
        public int ID { get; set; }

        [Field("AttributeID", "varchar", 20)]
        public string AttributeID { get; set; }

        [Field("AttributeName", "nvarchar", 20)]
        public string AttributeName { get; set; }

        [Field("AttributeDescription", "nvarchar", 50)]
        public string AttributeDescription { get; set; }
    }
}