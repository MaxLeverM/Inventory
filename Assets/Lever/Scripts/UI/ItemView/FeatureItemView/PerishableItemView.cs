using Lever.Scripts.Inventory;
using Lever.Scripts.Inventory.Feature;
using UnityEngine;

namespace Lever.Scripts.UI.ItemView.FeatureItemView
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