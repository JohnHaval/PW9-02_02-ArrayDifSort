using CreatingArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrayUnitTest
{
    [TestClass]
    public class ArraySorterTest
    {
        [TestMethod]//Смотреть трассировку отладки для этого метода
        public void TestFirstWayElementsSort()
        {
            var sortArr = ArrayCreator.CreateArray(5, 5, new ArrayCreator.Range(1, 15));
            TraceTransfer.ToTrace(sortArr);
            sortArr = ArraySorter.FirstWaySortToUpRowElements(sortArr);
            TraceTransfer.ToTrace(sortArr);
        }
        [TestMethod]//Смотреть трассировку отладки для этого метода
        public void TestSecondWayElementsSort()
        {
            var sortArr = ArrayCreator.CreateArray(5, 5, new ArrayCreator.Range(1, 15));
            TraceTransfer.ToTrace(sortArr);
            sortArr = ArraySorter.SecondWaySortToUpRowElements(sortArr);
            TraceTransfer.ToTrace(sortArr);
        }
        [TestMethod]//Смотреть трассировку отладки для этого метода
        public void FirstWayRowSort()
        {
            var sortArr = ArrayCreator.CreateArray(5, 5, new ArrayCreator.Range(1, 15));
            TraceTransfer.ToTrace(sortArr);
            sortArr = ArraySorter.SecondWaySortToUpRowElements(sortArr);
            TraceTransfer.ToTrace(sortArr);
            var testAvg = ArraySorter.FindArrayAvgOfRows(sortArr);
            TraceTransfer.ToTrace(testAvg);
            sortArr = ArraySorter.FirstWaySortToUpRowsOnAvgElements(sortArr);
            TraceTransfer.ToTrace(sortArr);
        }
        [TestMethod]//Смотреть трассировку отладки для этого метода
        public void SecondWayRowSort()
        {
            var sortArr = ArrayCreator.CreateArray(5, 5, new ArrayCreator.Range(1, 15));
            TraceTransfer.ToTrace(sortArr);
            sortArr = ArraySorter.SecondWaySortToUpRowElements(sortArr);
            TraceTransfer.ToTrace(sortArr);
            var testAvg = ArraySorter.FindArrayAvgOfRows(sortArr);
            TraceTransfer.ToTrace(testAvg);
            sortArr = ArraySorter.SecondWaySortToUpRowsOnAvgElements(sortArr);
            TraceTransfer.ToTrace(sortArr);
        }
    }
}
