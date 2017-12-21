using EasyBuyService.ORM.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyBuyService.ORM.Model
{
    [Table("dbo.Module","ID")]
    public class Module
    {
        [Field("ID", "int", 0)]
        public int ID { get; set; }

        [Field("ModuleID", "int", 0)]
        public int ModuleID { get; set; }

        [Field("ModuleName", "nvarchar", 20)]
        public string ModuleName { get; set; }

        [Field("ModuleDescription", "nvarchar", 200)]
        public string ModuleDescription { get; set; }

        [Field("Priority", "int", 0)]
        public int Priority { get; set; }

        [Field("Enable", "bit", 0)]
        public bool Enable { get; set; }
    }
}