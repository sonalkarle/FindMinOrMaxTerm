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
        //FIND MAXIMUM INTEGER
        [Test]
        public void GivenMaxInteger_AtFirstPosition_ShouldReturnTheSameNumber()
        {
            int result = testMaximum.GetMaximumInteger(88, 60, 44);
            Assert.AreEqual(88, result);
        }

        [Test]
        public void GivenMaxInteger_AtSecondPosition_ShouldReturnTheSameNumber()
        {
            int result = testMaximum.GetMaximumInteger(70, 88, 14);
            Assert.AreEqual(88, result);
        }

        [Test]
        public void GivenMaxInteger_AtThirdPosition_ShouldReturnTheSameNumber()
        {
            int result = testMaximum.GetMaximumInteger(70, 54, 88);
            Assert.AreEqual(88, result);
        }
  



//UC2: Max number for float
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
//UC3:Find max string from below

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
