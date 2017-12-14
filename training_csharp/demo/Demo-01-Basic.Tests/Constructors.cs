using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Demo_01_Basic.Tests
{
    public class I
    {
        public I(string location, string className)
        {
            Console.WriteLine("Step: {0} in {1}", location, className);
        }
    }

    public class A
    {
        private static I StaticField = new I("Static field initialized", "base class A");
        private I InstanceFieldSuper = new I("Instance field initialized", "base class A");

        static A()
        {
            new I("Static constructor", "base class A");
        }

        public A()
        {
            new I("Instance constructor", "base class A");
        }
    }

    public class B : A
    {
        private I InstanceField = new I("Instance field initialized", "class B");

        public B()
        {
            new I("Instance constructor", "class B");
        }
    }

    public class C
    {
        private static I StaticField = new I("Static field initialized", "class C");

        static C()
        {
            new I("Static constructor", "class C");
        }

        private I InstanceField = new I("Instance field initialized", "class C");

        public C()
        {
            new I("Instance constructor", "class C");
        }
    }

    [TestFixture]
    public class Constructors
    {
        [Test]
        public void Execution_Sequence_Demo1()
        {
            Console.WriteLine("Take 1");
            new B();
            Console.WriteLine("\r\nTake 2");
            new C();
        }
    }
}
