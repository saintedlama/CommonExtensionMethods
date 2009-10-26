using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

using CommonExtensionMethods.DateTimes;

namespace CommonExtensionMethodsTests
{
    [TestFixture]
    public class DatesTests
    {
        [Test]
        public void TestDates()
        {
            DateTime now = DateTime.Now;

            Assert.AreEqual(now.AddDays(2), 2.Days().After(now));
        }
    }
}
