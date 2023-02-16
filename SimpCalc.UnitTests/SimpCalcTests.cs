using NUnit.Framework;
using System;
using UnitTestingDemo;

namespace UnitTestingDemo
{
    [TestFixture]
    public class SimpCalcTests
    {
        public SimpCalc simpCalc;

        [SetUp]
        public void Setup()
        {
            simpCalc = new SimpCalc();
        }

        [Test]
        public void Sum_1and2_3returned()
        {
            //arrange
            var x = 1;
            var y = 2;
            var expected = 3;
            //act
            var actual = simpCalc.Add(x, y);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}