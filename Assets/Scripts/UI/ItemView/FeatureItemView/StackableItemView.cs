using System;
using System.Collections.Generic;
using System.Linq;
using Inventory;
using Sirenix.OdinInspector;
using UnityEngine;

namespace UI.FeatureItemView
{
    [Serializable]
    public class StackableItemView : FeatureItemView
    {
        public StackableItemView()
        {
            featureType = typeof(Stackable);
        }

        public override void Draw(ItemView itemView, Item item)
        {
            if (!item.FeatureExist(featureType))
                return;
            var feature = (Stackable)item.GetFeature(featureType);

            var totalWeight = feature.CurrentAmount * item.Weight;

            itemView.LeftUpperText.text = $"x{feature.CurrentAmount.ToString()}";
            itemView.RightBottomText.text = totalWeight.ToString("0.0");
        }
    }
}