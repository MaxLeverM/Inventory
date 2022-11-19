using System;
using UnityEngine;

namespace Lever.Scripts.Inventory.Feature
{
    [Serializable]
    public class Stackable : ItemFeature
    {
        [SerializeField] private int stackCapacity;
        private int currentAmount;

        public int StackCapacity => stackCapacity;

        public int CurrentAmount
        {
            get => currentAmount;
            set
            {
                var temp = value >= 1 ? value : 1;
                temp = value <= stackCapacity ? value : stackCapacity;
                currentAmount = temp;
            }
        }
    }
}