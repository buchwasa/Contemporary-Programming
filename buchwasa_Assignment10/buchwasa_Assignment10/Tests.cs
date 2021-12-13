using Algorithm;
using NUnit.Framework;

namespace buchwasa_Assignment10
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.IsTrue(Luhns.ValidateCard("79927398713"));
        }

        [Test]
        public void Test2()
        {
            Assert.IsTrue(Luhns.ValidateCard("4950467189610523"));
        }

        [Test]
        public void Test3()
        {
            Assert.IsFalse(Luhns.ValidateCard("9237428350232"));
        }

        [Test]
        public void Test4()
        {
            Assert.IsFalse(Luhns.ValidateCard("2348345934457"));
        }

        [Test]
        public void Test5()
        {
            Assert.IsTrue(Luhns.ValidateCard("3547759150140528"));
        }
    }
}