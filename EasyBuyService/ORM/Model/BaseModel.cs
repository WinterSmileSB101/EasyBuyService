using EasyBuyService.ORM.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyBuyService.ORM.Model
{
    public class BaseModel
    {
        [Field("InDate", "datetime", 0)]
        public int InDate { get; set; }

        [Field("InUser", "varchar", 20)]
        public int InUser { get; set; }

        [Field("LastEditDate", "datetime", 0)]
        public int LastEditDate { get; set; }

        [Field("LastEditUser", "varchar", 20)]
        public int LastEditUser { get; set; }
    }
}