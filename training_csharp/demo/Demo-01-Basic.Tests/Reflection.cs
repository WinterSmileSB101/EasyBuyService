using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using NUnit.Framework;

namespace Demo_01_Basic.Tests
{
    [AttributeUsage(AttributeTargets.Class, 
        AllowMultiple = false, 
        Inherited = true)]
    public class TableAttribute : System.Attribute
    {
        public string Name { get; private set; }

        public TableAttribute(string name)
        {
            Name = name;
        }
    }

    [AttributeUsage(AttributeTargets.Property,
        AllowMultiple = false,
        Inherited = true)]
    public class ColumnAttribute : System.Attribute
    {
        public bool IsPrimaryKey { get; set; }
        public string Name { get; private set; }
        public Type DataType { get; set; }

        public ColumnAttribute(string name)
        {
            Name = name;
        }
    }

    [Table("dbo.Customer")]
    public class NewCustomer
    {
        [Column("TransactionNumber",DataType = typeof(int))]
        public int ID { get; set; }

        [Column("Name")]
        public string Name { get; set; }
    }

    [TestFixture]
    public class AttributeTest
    {
        [Test]
        public void Test()
        {
            var type = typeof (NewCustomer);

            var tableAttribute = (TableAttribute)
                type.GetCustomAttributes(
                    typeof (TableAttribute),
                    true)[0];

            Assert.AreEqual("dbo.Customer", tableAttribute.Name);

            var properties = type.GetProperties();

            foreach (var propertyInfo in properties)
            {
                var attribute = 
                    (ColumnAttribute)propertyInfo.GetCustomAttributes(
                    typeof (ColumnAttribute),
                    true)[0];

                Console.WriteLine(attribute.Name);
            } 
        }
    }
}
