using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Demo_01_Basic.Tests
{
    public class ClassDefinition
    {
        public string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        

        public void SayHello()
        {
            Console.WriteLine("{0} says hello to you.", _name);
        }

        public void SayHello(string friend)
        {
            Console.WriteLine("{0} and {1} say hello to you", friend, _name);
        }

        public void SayHelloWith(params string[] friends)
        {
            Console.WriteLine("{0} and {1} say hello to you", 
                string.Join(",", friends),
                _name);
        }
    }

    [TestFixture]
    public class ClassDefinitionTest
    {
        [Test]
        public void Demo()
        {
            var anInstance = new ClassDefinition();
            anInstance.Name = "Steve";

            

            anInstance.SayHello();
            anInstance.SayHello("Tony");
            anInstance.SayHelloWith("Thor");
            anInstance.SayHelloWith("Thor","Rocky");
        }
    }
}
