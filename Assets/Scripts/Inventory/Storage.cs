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
            if (items.Count >= capacity)
                return;
            
            if (item.FeatureExist(typeof(Stackable)))
            {
                var stackableFeature = item.GetFeature(typeof(Stackable)) as Stackable;
                
                var totalWeight = stackableFeature.CurrentAmount * item.Weight;
                if (weight + totalWeight > maxWeight)
                    return;
                weight += totalWeight;

                var inventoryMatchItems = items.FindAll(x => x.ID == item.ID);
                foreach (var inventoryMatchItem in inventoryMatchItems)
                {
                    var matchFeature = inventoryMatchItem.GetFeature(typeof(Stackable)) as Stackable;
                    if (matchFeature.CurrentAmount <= matchFeature.StackCapacity)
                    {
                        var matchFeatureTotal = Math.Clamp(matchFeature.CurrentAmount + stackableFeature.CurrentAmount, 0, matchFeature.StackCapacity);
                        var stackableResult = matchFeature.CurrentAmount + stackableFeature.CurrentAmount -
                                              matchFeature.StackCapacity;
                        stackableResult = stackableResult > 0 ? stackableResult : 0;
                        matchFeature.CurrentAmount = matchFeatureTotal;
                        stackableFeature.CurrentAmount = stackableResult;
                    }
                }
                
                if (stackableFeature.CurrentAmount > 0)
                    items.Add(item);
            }
            else
            {
                if (weight + item.Weight > maxWeight)
                    return;
                weight += item.Weight;
                items.Add(item);
            }
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