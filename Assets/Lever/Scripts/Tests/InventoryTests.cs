using Lever.Scripts.Inventory;
using NSubstitute;
using NUnit.Framework;

namespace Lever.Scripts.Tests
{
    public class InventoryTests
    {
        [Test]
        public void WhenAddItem_AndInventoryIsEmpty_ThenItemsCountShouldBe1()
        {
            // Arrange.
            Storage storage = new Storage();
            Item item = new Item();

            // Act.
            storage.AddItem(item);

            // Assert.
            Assert.AreEqual(1,storage.Items.Count);
        }

        [Test]
        public void WhenAddItem_AndInventoryIsFull_ThenItemsCountShouldBeEqualsCapacity()
        {
            // Arrange.
            Storage storage = new Storage(10, 1f, 100f);
            Item item = new Item();
            // Act.
            for (int i = 0; i < 15; i++)
            {
                storage.AddItem(item);
            }
            // Assert.
            Assert.AreEqual(storage.Capacity, storage.Items.Count);
        }
    }
}
