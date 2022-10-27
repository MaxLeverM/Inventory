using System;
using Lever.Scripts.Inventory;
using UnityEngine;

namespace Lever.Scripts.UI.ItemView.FeatureItemView
{
    [Serializable]
    public abstract class FeatureItemView
    {
        [SerializeField, HideInInspector] protected Type featureType;
        public abstract void Draw(ItemView itemView, Item item);
    }
}