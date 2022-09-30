using System;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory
{
    [Serializable]
    public class Storage
    {
        [SerializeField] private int capacity;
        [SerializeField] private float perishableMultiplier = 1;
        [SerializeField] private List<Item> items;
        [SerializeField] private float weight;
        [SerializeField] private float maxWeight;

        public void AddItem(Item item)
        {
            items.Add(item);
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