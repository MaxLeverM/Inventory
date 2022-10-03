using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Inventory
{
    [Serializable]
    public class Perishable : ItemFeature
    {
        [PropertyTooltip("Decay time in seconds.")]
        [SerializeField] private float decayTime = 30;
        [ReadOnly][SerializeField] private float currentDecayTime;

        public float DecayTime => decayTime;

        public float CurrentDecayTime => currentDecayTime;
    }
}