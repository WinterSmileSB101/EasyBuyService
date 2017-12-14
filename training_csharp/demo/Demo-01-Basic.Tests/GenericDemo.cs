using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Demo_01_Basic.Tests
{
    public class Circle : AbstractShape, IShape
    { 
        public decimal Radius { get; private set; }

        public Circle(string name, decimal radius)
        {
            Name = name;
            Radius = radius;
        }

        public override decimal CalculateArea()
        {
            return (decimal)Math.PI*Radius*Radius;
        }
    }

    public class Square : AbstractShape, IShape
    {
        public decimal EdgeLength { get; private set; }

        public Square(string name, decimal length)
        {
            Name = name;
            EdgeLength = length;
        }

        public override decimal CalculateArea()
        {
            return EdgeLength * EdgeLength;
        }
    }

    public class Node<T> where T : IShape 
    {
        public T Data { get; set; }
        public List<Node<T>> Children { get; set; }
    }

    [TestFixture]
    public class GenericDemoTest
    {
        public void Test_Type_Constraint()
        {
            var node = new Node<Square>();
             
        }

        [Test]
        public void Generic_Collection_Test_Queue()
        {
            var genericQueue = new Queue<int>();
            for (var i = 0; i < 10; i++)
            {
                genericQueue.Enqueue(i);
            }

            while (genericQueue.Count > 0)
            {
                Console.Write(genericQueue.Dequeue());
            }
            
        }

        [Test]
        public void Generic_Collection_Test_Stack()
        {
            var genericStack = new Stack<int>();
            for (var i = 0; i < 10; i++)
            {
                genericStack.Push(i);
            }

            while (genericStack.Count > 0)
            {
                Console.Write(genericStack.Pop());
            }

        }

        [Test]
        public void Generic_Dictionary_Test()
        {
            var genericDic = new Dictionary<int, string>();
            for (var i = 0; i < 10; i++)
            {
                genericDic.Add(i, "Value " + (i+1));
            }

            foreach (var key in genericDic.Keys)
            {
                var value = genericDic[key];
                Console.WriteLine("Key: {0} Value: {1}",key, value);
            }

        }

        [Test]
        public void Generic_Collection_Test2_BoxingUnboxing()
        {
            var integerArrayList = new ArrayList { 1, 2, 3, 4, 5, 6 };
            var unboxedInt = (int)integerArrayList[0]; 
            Assert.AreEqual(1, unboxedInt);

            var integerList = new List<int> {1, 2, 3, 4, 5, 6};
            Assert.AreEqual(1, integerList[0]);
        }

        public static void CalculateShapeArea<TShape>(IEnumerable<TShape> shapes) 
            where TShape : IShape
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine("Area of {0} is {1}",
                    shape.Name,
                    shape.CalculateArea());
            }
        }
        
        [Test]
        public void Generic_Method_Test()
        {
            var c1 = new Circle("Circle 1", 10);
            var s1 = new Square("Square 1", 20);
            var c2 = new Circle("Circle 2", 20);

            var shapes = new List<IShape> {c1, s1, c2};

            CalculateShapeArea(shapes);
        }
    }
}
