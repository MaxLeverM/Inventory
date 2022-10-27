using UnityEngine;

namespace Lever.Scripts.Inventory.Feature
{
    public class QualityFeature : ItemFeature
    {
        [SerializeField] private float quality;
        public float Quality => quality;
    }
}