using System;
using Sirenix.Serialization;
using UnityEngine;

namespace Inventory
{
    public abstract class ItemFeature : ICloneable
    {
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}