using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Demo_01_Basic.Tests
{
    [TestFixture]
    public class ExtensionMethodDemo
    {
        private List<int> GetAnIntegerList(int count)
        {
            if (count < 0) return null;

            var list = new List<int>();

            for (var i = 1; i <= count; i++)
            {
                list.Add(i);
            }

            return list;
        }

        private void DumpIntegerListToConsole(List<int> list)
        {
            foreach (var i in list)
            {
                Console.WriteLine(i);
            } 
        }

        [Test]
        public void Without_Extension_Method()
        {
            var list = GetAnIntegerList(-1);

            if (null == list || list.Count == 0)
            {
                return;
            }

            DumpIntegerListToConsole(list);
        }

        [Test]
        public void With_Extension_Method()
        {
            var list = GetAnIntegerList(6);
            //if (list.IsEmpty()) return;

            if (list.IsEmpty()) return;

            DumpIntegerListToConsole(list);
        }
    }

    public static class IntegerListExtension
    {
        public static bool IsEmpty(this List<int> list)
        {
            return null == list || list.Count == 0;
        }
    }
}
