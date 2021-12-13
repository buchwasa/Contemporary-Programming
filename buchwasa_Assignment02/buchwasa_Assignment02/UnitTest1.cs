using KadaneAlgorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace buchwasa_Assignment02
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] A = new int[9] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Assert.AreEqual(6, Algorithm.Solve(A));
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] A = new int[7] { 4, 5, 7, 8, 3, 2, 6 };
            Assert.AreEqual(35, Algorithm.Solve(A));
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] A = new int[6] { 5, 9, 2, 5, 9, 3 };
            int result = Algorithm.Solve(A);
            Assert.IsFalse(result > 33);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] A = new int[12] { 12, 5, 2, 1, 1, 1, 9, 7, 2, 1, 8, 9 };
            int result = Algorithm.Solve(A);
            Assert.AreNotEqual(59, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int[] A = new int[7] { 2, 4, 7, 2, 2, 4, 1 };
            int result = Algorithm.Solve(A);
            Assert.IsTrue(result > 20);
        }
    }
}
