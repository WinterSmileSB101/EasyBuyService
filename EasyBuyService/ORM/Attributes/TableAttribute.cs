using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyBuyService.ORM.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    class TableAttribute : Attribute
    {
        private string _TableName;
        private string _PK;
        public TableAttribute(string tableName, string pk)
        {
            TableName = tableName;
            PK = pk;
        }
        public string TableName { get => _TableName; set => _TableName = value; }
        public string PK { get => _PK; set => _PK = value; }
    }
}