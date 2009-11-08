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
        private int[] _enumerable;

        private void NoAction()
        {
        }

        [SetUp]
        public void Setup()
        {
            _enumerable = new [] { 1, 2, 3, 4 };
        }

        [Test]
        public void TwoTimesShouldYieldTwoValues()
        {
            var result = 2.Times(i => i);

            Assert.That(result, Has.Some.EqualTo(0));
            Assert.That(result, Has.Some.EqualTo(1));
            Assert.That(result, Has.None.GreaterThan(1));
        }

        [Test]
        public void ForEachActionShouldBeCalledForeachItem()
        {
            int invoked = 0;

            _enumerable.ForEach((x) => {
                invoked += 1;
            });

            Assert.That(invoked, Is.EqualTo(_enumerable.Length));
        }

        [Test]
        public void ForEachActionShouldBeCalledForeachItem2()
        {
            int invoked = 0;
            _enumerable.ForEach((i, x) => {
                invoked += 1;
            });

            Assert.That(invoked, Is.EqualTo(_enumerable.Length));
        }

        [Test]
        public void ForEachFuncShouldBeCalledForeachItem()
        {
            var result = _enumerable.ForEach((x) => x);

            Assert.That(result, Is.EqualTo(_enumerable));
        }

        [Test]
        public void ForEachFuncShouldBeCalledForeachItem2()
        {
            var result = _enumerable.ForEach((i, x) => x);

            Assert.That(result, Is.EqualTo(_enumerable));
        }
    }
}
