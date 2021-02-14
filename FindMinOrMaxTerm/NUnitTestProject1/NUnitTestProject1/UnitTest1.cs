using NUnit.Framework;
using FindMinOrMaxTerm;

namespace NUnitTestProject
{
    public class findMaxNum
    {
        findMaxNum testMaximum;

        [SetUp]
        public void Setup()
        {
            testMaximum = new findMaxNum();
        }


        [Test]
        public void GivenMaxString_AtFirstPosition_ShouldReturnTheSameString()
        {
            string result = testMaximum.GetMaximumString("Zebra", "lion", "zebra");
            Assert.AreEqual("Zebra", result);
        }

        [Test]
        public void GivenMaxString_AtSeconndPosition_ShouldReturnTheSameString()
        {
            string result = testMaximum.GetMaximumString("zebra", "Zebra", "lion");
            Assert.AreEqual("Zebra", result);
        }

        [Test]
        public void GivenMaxString_AtThirdPosition_ShouldReturnTheSameString()
        {
            string result = testMaximum.GetMaximumString("Zebra", "lion", "zebra");
            Assert.AreEqual("Zebra", result);
        }
    }
    

}