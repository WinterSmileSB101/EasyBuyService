using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Demo_01_Basic.Tests
{
    [TestFixture]
    public class ExceptionDemoTest
    {
        private decimal Devide(decimal x, decimal y)
        {
            return x/y;
        }

        private decimal Arthimetic(decimal a, decimal b)
        {
            return Devide(a, b);
        }

        [Test]
        public void Normal_Program_Flow()
        {
            var actual = Devide(100, 10);

            Assert.AreEqual(10, actual);
        }

        [Test]
        public void Exception_Unhandled()
        {
            try
            {
                string value = null;

                value.ToUpper();

                var actual = Arthimetic(100, 0);

            }
            catch (DivideByZeroException ex)
            {
                Assert.AreEqual(typeof (System.DivideByZeroException),
                    ex.GetType());
            }
            catch (Exception exx)
            {
                Console.WriteLine(exx.Message +
                                  exx.StackTrace
                    );
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }

            //Assert.AreEqual(10, actual);
        }
    }
}
