using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;
using NUnit.Framework.Constraints;

using CommonExtensionMethods.Objects;

namespace CommonExtensionMethodsTests
{
    [TestFixture]
    public class ObjectTests
    {
        [Test]
        public void IfNullShouldInvokeActionOnNullObject()
        {
            object x = null;
            bool isNull = false;

            x.IfNull(() => isNull = true);

            Assert.That(isNull, Is.True);
        }

        [Test]
        public void IfNotNullShouldInvokeActionOnNonNullObject()
        {
            object x = new object();
            bool isNotNull = false;

            x.IfNotNull(val => isNotNull = true);
            
            Assert.That(isNotNull, Is.True);
        }
    }
}
