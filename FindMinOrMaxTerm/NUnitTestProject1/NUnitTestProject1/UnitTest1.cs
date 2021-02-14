using NUnit.Framework;
using FindMinOrMaxTerm;

namespace NUnitTestProject
{
    public class Tests
    {
        findMaxNum testMaximum;

        [SetUp]
        public void Setup()
        {
            testMaximum = new findMaxNum();
        }
        //FIND MAXIMUM INTEGER
        [Test]
        public void GivenMaxInteger_AtFirstPosition_ShouldReturnTheSameNumber()
        {
            int result = testMaximum.GetMaximumInteger(88, 60, 44);
            Assert.AreEqual(76, result);
        }

        [Test]
        public void GivenMaxInteger_AtSecondPosition_ShouldReturnTheSameNumber()
        {
            int result = testMaximum.GetMaximumInteger(70, 88, 14);
            Assert.AreEqual(76, result);
        }

        [Test]
        public void GivenMaxInteger_AtThirdPosition_ShouldReturnTheSameNumber()
        {
            int result = testMaximum.GetMaximumInteger(70, 54, 88);
            Assert.AreEqual(76, result);
        }
    }
}
