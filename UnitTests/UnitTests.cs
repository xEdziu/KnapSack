using dotnet_lab2;

namespace UnitTests
{
    [TestClass]
    public sealed class UnitTests
    {
        [TestMethod]
        public void TestItemCount()
        {
            Problem problem = new(5, 123);
            Assert.AreEqual(5, problem.Items.Count);
        }

        [TestMethod]
        public void TestSolveWithEnoughCapacity()
        {
            Problem problem = new(5, 123);
            Result result = problem.Solve(100);
            Assert.IsTrue(result.SelectedItems.Count > 0);
        }

        [TestMethod]
        public void TestSolutionPicksMostValuableItems()
        {
            int capacity = 10;
            Problem problem = new Problem(5, 123);

            Result result = problem.Solve(capacity);
            Assert.IsNotNull(result, "Rozwiązanie nie powinno być puste!");

            var sortedItems = problem.Items.OrderByDescending(i => (double)i.GetValue() / i.GetWeight()).ToList();
            var firstPickedItem = result.SelectedItems.FirstOrDefault();

            if (firstPickedItem != null)
            {
                Assert.AreEqual(sortedItems[0].GetValue(), firstPickedItem.GetValue(), "Najbardziej wartościowy przedmiot nie został wybrany jako pierwszy!");
            }
        }

        [TestMethod]
        public void TestSolveWithZeroCapacity()
        {
            Problem problem = new(5, 123);
            Result result = problem.Solve(0);
            Assert.IsTrue(result.SelectedItems.Count == 0);
        }

        [TestMethod]
        public void TestSolutionDoesNotExceedCapacity()
        {
            Problem problem = new(5, 123);
            Result result = problem.Solve(100);
            Assert.IsTrue(result.SelectedItems.Sum(i => i.GetWeight()) <= 100);
        }
    }
}
