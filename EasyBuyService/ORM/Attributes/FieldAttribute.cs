using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyBuyService.ORM.Attributes
{
    [AttributeUsage(AttributeTargets.Property,AllowMultiple = false,Inherited = false)]
    public class FieldAttribute : Attribute
    {
        public string Fields { get; set; }

        public string DataType { get; set; }

        public string ValueLength { get; set; }

        public FieldAttribute(string fields, string dataType, int length)
        {
            Fields = fields;
            DataType = dataType;
            ValueLength = length;
        }
    }
}