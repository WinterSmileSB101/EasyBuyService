using System;
using NUnit.Framework;

namespace Demo_01_Basic.Tests
{
    
    [TestFixture]
    public class EventDemoTest
    {
        private event EventHandler<EventArgs> CalculationCompleted;
        
        private Action<object, EventArgs> CalculationCompletedAction;

        private Action<object, EventArgs> _CalculationCompletedAlt;

        public event Action<object, EventArgs> CalculationCompletedAlt
        {
            add
            {
                lock (this)
                {
                    _CalculationCompletedAlt += value;    
                    Console.WriteLine("Adder was called.");
                }
            }
            remove
            {
                lock (this)
                {
                    _CalculationCompletedAlt -= value;
                    Console.WriteLine("Remover was called.");
                }
            }
        }
        
        [Test]
        public void Test_Event()
        {
            CalculationCompleted += (object sender, EventArgs e) => Console.WriteLine("Event handler 1 ");
            CalculationCompleted += (object sender, EventArgs e) => Console.WriteLine("Event handler 2 ");
            
            CalculationCompleted(this, new EventArgs());

            CalculationCompleted = (object sender, EventArgs e) => Console.WriteLine("Event handler 3 ");

            CalculationCompleted(this, new EventArgs());
        }

        [Test]
        public void Test_Delegate()
        {
            CalculationCompletedAction += (sender, e) => Console.WriteLine("Delegate 1 ");
            CalculationCompletedAction += (sender, e) => Console.WriteLine("Delegate 2 ");

            CalculationCompletedAction(this, new EventArgs());
        }

        [Test]
        public void Test_EventAlt()
        {
            CalculationCompletedAlt -= null;

            CalculationCompletedAlt += (sender, e) => Console.WriteLine("Event handler 1 ");
            CalculationCompletedAlt += (sender, e) => Console.WriteLine("Event handler 2 ");

            _CalculationCompletedAlt(this, new EventArgs());
        }

        private int AddTwoIntegersTogether(int x, int y)
        {
            return x + y;
        }

        private int Multiple(int x, int y)
        {
            return x * y;
        }

        [Test]
        public void Func_Named_Method_Demo()
        {
            
            var function = new Func<int, int, int>(AddTwoIntegersTogether);

            //Func<> to see overloads of Func

            Assert.AreEqual(3, function(1, 2));

            function = new Func<int, int, int>(Multiple);

            Assert.AreEqual(2, function(1, 2));
        }

        [Test]
        public void Func_Anonymous_Method_Demo()
        {
            Func<int, int, int> function = delegate(int x, int y)
            {
                return x + y;
            };
             
            Assert.AreEqual(3, function(1, 2));

            function = delegate(int x, int y)
            {
                return x * y;
            };

            Assert.AreEqual(2, function(1, 2));
        }

        [Test]
        public void Func_Lambda_Expression_Demo()
        {
            Func<int, int, int> function = (x, y) => x + y;

            Assert.AreEqual(3, function(1, 2));

            function = (x, y) => x*y;

            Assert.AreEqual(2, function(1, 2));
        }

        private void PlusTwoIntegersAndPrintToConsole(int x, int y)
        {
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
        }

        [Test]
        public void Action_Demo()
        {
            var action = new Action<int, int>(PlusTwoIntegersAndPrintToConsole);

            action(1, 2);
        }

        [Test]
        public void Action_Anonymous_Method_Demo()
        {
            Action<int, int> action = delegate(int x, int y)
            {
                Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            };

            action(1, 2);
        }

        [Test]
        public void Action_Lambda_Expression_Demo()
        {
            Action<int, int> action = (x, y) => Console.WriteLine("{0} + {1} = {2}", x, y, x + y);

            action(1, 2);
        }
    }
}
