using NUnit.Framework;
using FindMinOrMaxTerm;

namespace NUnitTestProject
{
    public class findMaxNum
    {
        findMaxNum testMaximumnum;

        [SetUp]
        public void Setup()
        {
            testMaximumnum = new findMaxNum();
        }
    
      
            public void GivenMaxFlaot_AtFirstPosition_ShouldReturnTheSameNumber()
            {
                float result = testMaximumnum.GetMaximumFlaot(88.1f, 60.4f, 55.8f);
                Assert.AreEqual(88.1f, result);
            }

            [Test]
            public void GivenMaxFlaot_AtSecondPosition_ShouldReturnTheSameNumber()
            {
                float result = testMaximumnum.GetMaximumFlaot(60.4f, 88.1f, 55.3f);
                Assert.AreEqual(88.1f, result);
            }

            [Test]
            public void GivenMaxFlaot_AtThirdPosition_ShouldReturnTheSameNumber()
            {
                float result = testMaximumnum.GetMaximumFlaot(54.2f, 60.3f, 88.1f);
                Assert.AreEqual(88.1f, result);
            }
    }
    

}
