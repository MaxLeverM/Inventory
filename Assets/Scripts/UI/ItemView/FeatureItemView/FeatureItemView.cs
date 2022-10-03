using System;
using Inventory;
using UnityEngine;

namespace UI.FeatureItemView
{
    [Serializable]
    public abstract class FeatureItemView
    {
        [SerializeField, HideInInspector] protected Type featureType;
        public abstract void Draw(ItemView itemView, Item item);
    }
}