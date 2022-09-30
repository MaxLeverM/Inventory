using System;
using UnityEngine;

namespace Inventory
{
    [Serializable]
    public class Stackable : ItemFeature
    {
        [SerializeField] private int stackCapacity;
        [SerializeField] private int currentAmount;

        public int StackCapacity
        {
            get => stackCapacity;
            set => stackCapacity = value;
        }

        public int CurrentAmount
        {
            get => currentAmount;
            set => currentAmount = value;
        }
    }
}