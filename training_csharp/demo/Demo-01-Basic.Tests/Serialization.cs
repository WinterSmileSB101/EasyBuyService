using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Demo_01_Basic.Tests
{
    public class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    [TestFixture]
    public class SerializationDemo
    {
        [Test]
        public void Test()
        {
            var product = new Product
            {
                ID = "P01", 
                Name = "My Product"
            };

            var content = JsonConvert.SerializeObject(product);

             
            Console.WriteLine(content);

            var product1 = JsonConvert.DeserializeObject<Product>(content);

            Assert.AreEqual("P01", product1.ID);
            Assert.AreEqual("My Product", product1.Name);

            Assert.IsFalse(ReferenceEquals(product, product1));
        }
    }
}
