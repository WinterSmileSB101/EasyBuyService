using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Demo_01_Basic.Tests
{
    [TestFixture]
    public class AnonymousMethodDemo
    {
        [Test]
        public void AnonymousMethod_Test()
        {
            var task = new Task(delegate()
            {
                Console.WriteLine("Running in a task.");
            });

            task.Start();
            task.Wait();
        }

        
    }
}
