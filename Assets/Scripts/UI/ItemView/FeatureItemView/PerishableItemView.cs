using System;
using Inventory;
using UnityEngine;

namespace UI.FeatureItemView
{
    public class PerishableItemView : FeatureItemView
    {
        public PerishableItemView()
        {
            featureType = typeof(Perishable);
        }
        
        public override void Draw(ItemView itemView, Item item)
        {
            if (!item.FeatureExist(featureType))
                return;
            var feature = (Perishable)item.GetFeature(featureType);
            
            itemView.BottomBar.color = Color.green;
            itemView.BottomBar.fillAmount =
                Mathf.InverseLerp(0, feature.DecayTime, feature.DecayTime - feature.CurrentDecayTime);
        }
    }
}