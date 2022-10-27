using System;

namespace Lever.Scripts.Inventory.Feature
{
    public abstract class ItemFeature : ICloneable
    {
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}