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
            string result = testMaximum.GetMaximumString("Jackfruit", "Per", "mango");
            Assert.AreEqual("Jackfruit", result);
        }

        [Test]
        public void GivenMaxString_AtSeconndPosition_ShouldReturnTheSameString()
        {
            string result = testMaximum.GetMaximumString("mango", "Jackfruit", "per");
            Assert.AreEqual("Jackfruit", result);
        }

        [Test]
        public void GivenMaxString_AtThirdPosition_ShouldReturnTheSameString()
        {
            string result = testMaximum.GetMaximumString("mango", "per", "Jackfruit");
            Assert.AreEqual("Jackfruit", result);
        }
    }
    

}