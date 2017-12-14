using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Demo_01_Basic.Tests
{
    public abstract class AbstractShape
    {
        public string Name { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing a {0}", Name);
        }
        public abstract decimal CalculateArea();
    }

    public class Shape : IShape
    {
        public virtual string Name { get; set; }
        public virtual string Memo { get; set; }

        public virtual void Draw() { }
        public virtual decimal CalculateArea()
        {
            return 0;
        }
    }

    public class Rectangle : Shape
    {
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public new string Name { get; set; }
        public override string Memo { get; set; }


        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }

        public override decimal CalculateArea()
        {
            return Length * Width;
        }
    }

    [TestFixture]
    public class InheritanceDemoTest
    {
        [Test]
        public void New_vs_Override_Demo()
        {
            var shape = new Rectangle();
            shape.Name = "A Rectangle";
            ((Shape) shape).Name = "A Shape";

            Assert.AreEqual("A Rectangle", shape.Name);
            Assert.AreEqual("A Shape", ((Shape)shape).Name);

            shape.Memo = "Memo of Rectangle";
            ((Shape)shape).Memo = "Memo of Shape";

            Assert.AreEqual("Memo of Shape", shape.Memo);
            Assert.AreEqual("Memo of Shape", ((Shape)shape).Memo);
        }
    }
}
