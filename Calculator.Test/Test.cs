using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SampleAppVeyor;

namespace Calculator.Test
{
    [TestFixture]
    public class Test
    {
        private SampleAppVeyor.Calculator _calculator;

        [SetUp]
        public void setup()
        {
            _calculator = new SampleAppVeyor.Calculator();
        }
        [Test]
        public void OnePlusOne()
        {
            Assert.AreEqual(2, _calculator.Add(1, 1));

        }
        [Test]
        public void ThreeSubOne()
        {
            Assert.AreEqual(2, _calculator.Subtract(3, 1));
        }
    }
}
