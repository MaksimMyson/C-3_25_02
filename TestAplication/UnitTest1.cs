using Core;
namespace TestApplication
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBubbleSortAscending()
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            int[] expected = { 11, 12, 22, 25, 34, 64, 90 };

            SortingHelper.BubbleSort(arr, ascending: true);

            CollectionAssert.AreEqual(expected, arr);
        }

        [TestMethod]
        public void TestBubbleSortDescending()
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            int[] expected = { 90, 64, 34, 25, 22, 12, 11 };

            SortingHelper.BubbleSort(arr, ascending: false);

            CollectionAssert.AreEqual(expected, arr);
        }

        [TestMethod]
        public void TestSelectionSortAscending()
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            int[] expected = { 11, 12, 22, 25, 34, 64, 90 };

            SortingHelper.SelectionSort(arr, ascending: true);

            CollectionAssert.AreEqual(expected, arr);
        }
    }
}