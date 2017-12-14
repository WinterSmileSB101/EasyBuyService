using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Demo_01_Basic.Tests
{
    [TestFixture]
    public class LambdaDemo
    {
        [Test]
        public void Lambda_Test()
        {
            var task = new Task(() => Console.WriteLine("Running in a task."));

            task.Start();
            task.Wait();
        }
    }
}
