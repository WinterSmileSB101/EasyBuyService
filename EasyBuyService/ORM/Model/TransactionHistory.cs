using EasyBuyService.ORM.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyBuyService.ORM.Model
{
    [Table("dbo.TransactionHistory","ID")]
    public class TransactionHistory
    {
        [Field("ID", "int", 0)]
        public int ID { get; set; }

        [Field("TransactionNumber", "varchar", 20)]
        public string TransactionNumber { get; set; }

        [Field("FromUser", "varchar", 200)]
        public string FromUser { get; set; }

        [Field("ToUser", "varchar", 200)]
        public string ToUser { get; set; }

        [Field("Title", "nvarchar", 30)]
        public string Title { get; set; }

        [Field("Status", "int", 0)]
        public int Status { get; set; }

        [Field("Description", "nvarchar", 200)]
        public string Description { get; set; }

        [Field("Comment", "nvarchar", 200)]
        public string Comment { get; set; }

        [Field("TransactionCount", "decimal",0)]
        public float TransactionCount { get; set; }
    }
}