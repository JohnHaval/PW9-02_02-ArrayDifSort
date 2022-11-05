using CreatingArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrayUnitTest
{
    [TestClass]
    public class ArrayCreatorTest
    {
        [TestMethod]
        public void CreateArrayWith0()
        {
            double[,] arr0 = ArrayCreator.CreateArray(4, 4);
            TraceTransfer.ToTrace(arr0);
            Assert.AreEqual(0, arr0[0, 0]);
        }
        [TestMethod]
        public void CreateArrayWithRandom()
        {
            double[,] arr0 = ArrayCreator.CreateArray(4, 4, new ArrayCreator.Range(2, 10));
            TraceTransfer.ToTrace(arr0);
            Assert.IsTrue(arr0[0, 0] != 0);
        }
    }
}
