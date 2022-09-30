using UnityEngine;

namespace Inventory
{
    public class QualityFeature : ItemFeature
    {
        [SerializeField] private float quality;
        public float Quality => quality;
    }
}