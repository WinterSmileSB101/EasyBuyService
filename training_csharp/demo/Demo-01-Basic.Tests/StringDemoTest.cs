using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Demo_01_Basic.Tests
{
    [TestFixture]
    public class StringDemoTest
    {
        [Test]
        public void Basic()
        {
            string str1 = "English 中文 にほんご Español le français";

            Console.WriteLine("Length:{0}", str1.Length);
            
            Console.WriteLine(str1);

            foreach (var ch in str1)
            {
                Console.WriteLine(ch);    
            }
        }

        [Test]
        public void Equal_Two_Literals_Tests()
        {
            var value1 = "string";
            var value2 = "string"; 
            
            #region Compare by value
            Assert.IsTrue(value1.Equals(value2));
            #endregion

            #region Compare by HashCode
            Assert.IsTrue(value1.GetHashCode().Equals(value2.GetHashCode()));
            #endregion

            #region Compare by Reference
            Assert.IsTrue(ReferenceEquals(value1, value2));  
            #endregion
        }

        [Test]
        public void Equal_Two_Literals_Plus_Test()
        {
            var value1 = "string"; 
            var value2 = "str" + "ing";

            #region Compare by value
            Assert.IsTrue(value1.Equals(value2));
            #endregion

            #region Compare by HashCode
            Assert.IsTrue(value1.GetHashCode().Equals(value2.GetHashCode()));
            #endregion

            #region Compare by Reference
            Assert.IsTrue(ReferenceEquals(value1, value2));  
            #endregion
        }

        [Test]
        public void Equal_Literal_vs_StringBuilder_Test()
        {
            var value1 = "string";
            var value2 = new StringBuilder("string").ToString();

            #region Compare by value
            Assert.IsTrue(value1.Equals(value2));
            #endregion

            #region Compare by HashCode
            Assert.IsTrue(value1.GetHashCode().Equals(value2.GetHashCode()));
            #endregion

            #region Compare by Reference
            Assert.IsFalse(ReferenceEquals(value1, value2));  
            #endregion
        }

        [Test]
        public void Equal_Literal_vs_String_Manuplation_Test()
        {
            var value1 = "string";
            var value2 = "string1".Substring(0, 6);

            #region Compare by value
            Assert.IsTrue(value1.Equals(value2));
            #endregion

            #region Compare by HashCode
            Assert.IsTrue(value1.GetHashCode().Equals(value2.GetHashCode()));
            #endregion

            #region Compare by Reference
            Assert.IsFalse(ReferenceEquals(value1, value2));  
            #endregion
        }

        [Test]
        public void Equal_Literal_vs_String_Intern_Test()
        {
            var value1 = "string";
            var value2 = string.Intern("string1".Substring(0, 6));

            #region Compare by value
            Assert.IsTrue(value1.Equals(value2));
            #endregion

            #region Compare by HashCode
            Assert.IsTrue(value1.GetHashCode().Equals(value2.GetHashCode()));
            #endregion

            #region Compare by Reference
            Assert.IsTrue(ReferenceEquals(value1, value2));  
            #endregion
        }

        [Test]
        public void Immutable_String_Test()
        {
            var value1 = "string";

            var value2 = value1.Substring(0, 3);

            Assert.AreEqual("str",value2);

            #region How about value1 ?
            Assert.AreEqual("string", value1);
            #endregion

            value2 = value1.ToUpper();

            Assert.AreEqual("STRING", value2);

            #region How about value1 ?
            Assert.AreEqual("string", value1);
            #endregion
        }
    }
}
