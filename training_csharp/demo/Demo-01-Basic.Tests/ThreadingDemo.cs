using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Demo_01_Basic.Tests
{
    [TestFixture]
    public class ThreadingDemo
    {
        [Test]
        public void Deadlock()
        {
            var thread1 = new Task(
                () => { lock (typeof(float))
                            {
                                Console.WriteLine("[Child Thread] A is locked");
                                Thread.Sleep(200);
                                Console.WriteLine("[Child Thread] Trying to lock B...");
                                lock (typeof(int))
                                {
                                    Console.WriteLine("[Child Thread] Do something.");
                                }
                            }
                    });

            thread1.Start();

            lock (typeof(int))
            {
                Console.WriteLine("[Main Thread] B is locked");
                Thread.Sleep(200);
                Console.WriteLine("[Main Thread] Trying to lock A...");
                lock (typeof(float))
                {
                    Console.WriteLine("[Main Thread] Do something.");
                }
            }
        }

        [Test]
        public void None_Thread_Safe_List_Demo()
        {
            var list = new List<int>();

            var task1 = new Task(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(200);
                    if (list.Contains(i)) continue;
                    list.Add(i);
                }
            });

            var task2 = new Task(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(200);
                    if (list.Contains(i)) continue;
                    list.Add(i);
                }
            });

            task1.Start();
            task2.Start();

            task2.Wait();

            list.ForEach(i => Console.WriteLine(i));
        }

        [Test]
        public void None_Thread_Safe_Dictionary_Demo()
        {
            var list = new Dictionary<int, string>();

            var task1 = new Task(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(50);
                    if (list.ContainsKey(i)) continue;
                    list.Add(i,"Value " + i);
                }
            });

            var task2 = new Task(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(50);
                    if (list.ContainsKey(i)) continue;
                    list.Add(i, "Value " + i);
                }
            });

            task1.Start();
            task2.Start();

            task2.Wait();

            Console.WriteLine("Dictionary.Count: {0}", list.Count);

            foreach (var key in list.Keys)
            {
                Console.WriteLine(list[key]);
            }
        }

        [Test]
        public void Thread_Safe_List_Demo()
        {
            var list = new List<int>(); 

            var task1 = new Task(() =>
            {
                for (var i = 0; i < 10; i++)
                {
                    Thread.Sleep(200);
                    lock (list)
                    {
                        if (list.Contains(i)) continue;
                        list.Add(i);    
                    }
                }
            });

            var task2 = new Task(() =>
            {
                for (var i = 0; i < 10; i++)
                {
                    Thread.Sleep(200);
                    lock (list)
                    {
                        if (list.Contains(i)) continue;
                        list.Add(i);
                    }
                }
            });

            task1.Start();
            task2.Start();

            task1.Wait();
            task2.Wait();

            list.ForEach(i => Console.WriteLine(i));
        }

        [Test]
        public void ConcurrentDictionary_Demo()
        {
            //System.Collections.Concurrent.;

            var list = new ConcurrentDictionary<int, string>();

            var task1 = new Task(() =>
            {
                for (var i = 0; i < 10; i++)
                {
                    var value = "[T1]Value " + i;
                    Thread.Sleep(100);
                    list.AddOrUpdate(i, k=>value,(key, oldKey)=>value); 
                }
            });

            var task2 = new Task(() =>
            {
                for (var i = 0; i < 10; i++)
                {
                    var value = "[T2]Value " + i;
                    Thread.Sleep(100);
                    list.AddOrUpdate(i, k => value, (key, oldKey) => value); 
                }
            });

            task1.Start();
            task2.Start();

            task1.Wait();
            task2.Wait();

            Console.WriteLine("Dictionary.Count: {0}", list.Count);

            foreach (var key in list.Keys)
            {
                Console.WriteLine(list[key]);
            }
        }
    }
}
