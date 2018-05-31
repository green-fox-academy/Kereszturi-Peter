using Apples;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestFixture]
    public class AppleTester
    {
        Apple rottenApple = new Apple();

        [TestCase("apple")]
        public void IsAppleEqualsApple(string word)
        {
            Assert.AreEqual("apple", rottenApple.GetApple());
        }
    }
}
