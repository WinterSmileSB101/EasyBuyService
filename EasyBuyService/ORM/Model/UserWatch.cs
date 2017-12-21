using EasyBuyService.ORM.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyBuyService.ORM.Model
{
    [Table("dbo.UserWatch", "ID")]
    public class UserWatch: BaseModel
    {
        [Field("ID", "int", 0)]
        public int ID { get; set; }

        [Field("UserID", "varchar", 200)]
        public string UserID { get; set; }

        [Field("WatchID", "varchar", 200)]
        public string WatchID { get; set; }

        [Field("WatchID", "int", 0)]
        public int WatchType { get; set; }
    }
}