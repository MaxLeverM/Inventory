namespace Inventory
{
    public class Ingredient
    {
        private Item item;
        private int amount;

        public Item Item
        {
            get => item;
            set => item = value;
        }

        public int Amount
        {
            get => amount;
            set => amount = value;
        }
    }
}