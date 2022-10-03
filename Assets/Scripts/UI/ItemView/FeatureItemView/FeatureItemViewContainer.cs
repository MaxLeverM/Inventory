using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace UI.FeatureItemView
{
    [CreateAssetMenu(fileName = "FeatureItemViewContainer", menuName = "Lever/FeatureItemViewContainer")]
    public class FeatureItemViewContainer : SerializedScriptableObject
    {
       // [NonSerialized, OdinSerialize]
        [SerializeField] private List<FeatureItemView> featureItemViews;

        public List<FeatureItemView> FeatureItemViews=>featureItemViews;
    }
}