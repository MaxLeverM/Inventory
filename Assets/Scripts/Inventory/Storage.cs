using System.Collections.Generic;
using UnityEngine;

namespace Inventory
{
    public class Storage
    {
        private int capacity;
        private float perishableMultiplier;
        private List<Item> items;
        private float weight;
        private float maxWeight;

        public void AddItem(Item item)
        {
        }

        public void AddItems(IEnumerator<Item> itemsToAdd)
        {
        }

        public void RemoveItem(Item item)
        {
        }

        public void RemoveItems(IEnumerator<Item> itemsToRemove)
        {
        }
    }
}