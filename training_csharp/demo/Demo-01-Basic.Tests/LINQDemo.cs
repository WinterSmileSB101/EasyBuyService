using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Demo_01_Basic.Tests
{
    [TestFixture]
    public class LINQDemo
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

        [Test]
        public void List_Find_EvenNumbers_Demo()
        {
            var integerList = GetAnIntegerList(10);

            foreach (var i in integerList)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine("{0} is a even number", i);
                }
            }
        }

        [Test]
        public void List_Find_EvenNumbers_With_LINQ_Demo()
        {
            var integerList = GetAnIntegerList(10);

            IEnumerable<int> result = (
                from i in integerList
                where i%2 == 0
                select i
                );

            result.ToList().ForEach(i => Console.WriteLine("{0} is a even number", i));
        }

        [Test]
        public void Delayed_Execution_Demo()
        {
            var integerList = GetAnIntegerList(10);

            IEnumerable<Record> result = (
                from i in integerList 
                select new Record(i)
                );

            Console.WriteLine("Result retrieved.");
            foreach (var record in result)
            {
                Console.WriteLine("Record==>{0}", record.ID);
            }
        }
        /*
         * 
         * Result retrieved.
Building Record [1]
Record==>1
Building Record [2]
Record==>2
Building Record [3]
Record==>3
Building Record [4]
Record==>4
Building Record [5]
Record==>5
Building Record [6]
Record==>6
Building Record [7]
Record==>7
Building Record [8]
Record==>8
Building Record [9]
Record==>9
Building Record [10]
Record==>10
         */
    }

    public class Record
    {
        public int ID { get; set; }

        public Record(int id)
        {
            ID = id;
            Console.WriteLine("Building Record [{0}]", id);
        }
    }
}
