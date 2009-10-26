using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using NUnit.Framework.Constraints;

using CommonExtensionMethods.Enumerations;

namespace CommonExtensionMethodsTests
{
    [TestFixture]
    public class EnumerationTests
    {
        [Test]
        public void TwoTimesShouldYieldTwoValues()
        {
            var result = 2.Times(i => i);

            Assert.That(result, Has.Some.EqualTo(0));
            Assert.That(result, Has.Some.EqualTo(1));
            Assert.That(result, Has.None.GreaterThan(1));
        }
    }
}
