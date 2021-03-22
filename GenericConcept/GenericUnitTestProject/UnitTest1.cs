using GenericConcept;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
            [TestMethod]
            public void Given_MaxIntegerNumber_1st_Position_ShouldReturnSame()
            {
                int max = GenericClass<int>.maximum(8, 5, 6);
                Assert.AreEqual(8, max);
            }
            [TestMethod]
            public void Given_MaxIntegerNumber_2nd_Position_ShouldReturnSame()
            {
                int max = GenericClass<int>.maximum(5, 8, 6);
                Assert.AreEqual(8, max);
            }

            [TestMethod]
            public void Given_MaxIntegerNumber_3rd_Position_ShouldReturnSame()
            {
                int max = GenericClass<int>.maximum(5, 6, 8);
                Assert.AreEqual(8, max);
            }
        [TestMethod]
        public void Given_MaxFloatNumber_1st_Position_ShouldReturnSame()
        {
            float max = GenericClass<float>.maximum(8.5f, 5.5f, 6.5f);
            Assert.AreEqual(8.5f, max);
        }
        [TestMethod]
        public void Given_MaxFloatNumber_2nd_Position_ShouldReturnSame()
        {
            float max = GenericClass<float>.maximum(5.5f, 8.5f, 6.5f);
            Assert.AreEqual(8.5f, max);
        }

        [TestMethod]
        public void Given_MaxFloatNumber_3rd_Position_ShouldReturnSame()
        {
            float max = GenericClass<float>.maximum(5.5f, 6.5f, 8.5f);
            Assert.AreEqual(8.5f, max);
        }

    }
}
