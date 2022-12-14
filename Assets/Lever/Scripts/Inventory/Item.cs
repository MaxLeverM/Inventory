using System;
using System.Collections.Generic;
using System.Linq;
using Lever.Scripts.Inventory.Feature;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Lever.Scripts.Inventory
{
    [Serializable]
    public class Item : ICloneable
    {
        [SerializeField] private int id;
        [SerializeField] private string title;
        [SerializeField] private string description;
        [PreviewField][SerializeField] private Sprite icon;
        [SerializeField] private float weight;
        [SerializeField][TypeFilter("GetFilteredTypeList")]
        private List<ItemFeature> features = new List<ItemFeature>();

        public int ID => id;

        public string Title => title;

        public string Description => description;

        public float Weight => weight;

        public Sprite Icon => icon;

        public ItemFeature GetFeature(Type featureType)
        {
            var itemFeature = features.Find(x => x.GetType() == featureType);
            return itemFeature;
        }
        
        public bool FeatureExist(Type featureType)
        {
            return features.Exists(x => x.GetType() == featureType);
        }

        private IEnumerable<Type> GetFilteredTypeList()
        {
            var q = typeof(ItemFeature).Assembly.GetTypes()
                .Where(x => !x.IsAbstract)
                .Where(x => !x.IsGenericTypeDefinition)
                .Where(x => typeof(ItemFeature).IsAssignableFrom(x))
                .Where(x=> !features.Exists(k=>k.GetType()==x));
            return q;
        }

        public object Clone()
        {
            var itemCopy = (Item)MemberwiseClone();
            var featuresCopy = new List<ItemFeature>();
            foreach (var feature in features)
            {
                featuresCopy.Add((ItemFeature)feature.Clone());
            }
            itemCopy.features = featuresCopy;
            return itemCopy;
        }
    }
}