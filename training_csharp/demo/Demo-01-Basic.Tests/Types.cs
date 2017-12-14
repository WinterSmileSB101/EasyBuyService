using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using NUnit.Framework;

namespace Demo_01_Basic.Tests
{
    public class Customer
    {
        public string Name;
    }

    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public struct CustomerRecord
    {
        public int ID; 
        public Customer Customer;

        public CustomerRecord(int id, string name)
        {
            ID = id;
            Customer = new Customer { Name = name };
        }

        public CustomerRecord(int id, Customer customer)
        {
            ID = id;
            Customer = customer;
        }
    }
    
    [TestFixture]
    public class Types
    {
        [Test]
        public void ValueType_Demo1()
        {
            var int1 = 1;
            var int2 = int1;

            Assert.AreEqual(1, int1); 
            Assert.AreEqual(1, int2);

            int2 = 2;

            Assert.AreEqual(1, int1); 
            Assert.AreEqual(2, int2);
        }

        [Test]
        public void ValueType_Demo2()
        {
            var p1 = new Point(1, 2);
            var p2 = p1;

            Assert.AreEqual(1, p1.X); Assert.AreEqual(2, p1.Y);
            Assert.AreEqual(1, p2.X); Assert.AreEqual(2, p2.Y);

            p2.X = 3; p2.Y = 4;

            Assert.AreEqual(1, p1.X); Assert.AreEqual(2, p1.Y);
            Assert.AreEqual(3, p2.X); Assert.AreEqual(4, p2.Y);
        }

        [Test]
        public void ReferenceType_Demo()
        {
            var customer1 = new Customer {Name = "Hulk"};
            var customer2 = customer1;

            Assert.AreEqual("Hulk", customer1.Name);
            Assert.AreEqual("Hulk", customer2.Name);

            customer2.Name = "Thor";

            Assert.AreEqual("Thor", customer1.Name);

            customer2 = new Customer { Name = "Steve" };

            Assert.AreEqual("Thor", customer1.Name);
            Assert.AreEqual("Steve", customer2.Name);
        }

        [Test]
        public void ValueType_Boxing_and_Unboxing_Demo1()
        {
            var a = (object)2;
            var b = (int)a;
        }
    }
}
