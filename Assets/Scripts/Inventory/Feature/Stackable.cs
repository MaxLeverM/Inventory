using System;
using UnityEngine;

namespace Inventory
{
    [Serializable]
    public class Stackable : ItemFeature
    {
        [SerializeField] private int stackCapacity;
        [SerializeField] private int currentAmount;

        public int StackCapacity => stackCapacity;

        public int CurrentAmount
        {
            get => currentAmount;
            set => currentAmount = value;
        }
    }
}