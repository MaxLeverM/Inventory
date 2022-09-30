using System;
using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using Sirenix.Utilities;
using UnityEngine;

namespace Inventory
{
    [CreateAssetMenu(fileName = "ItemSetting", menuName = "Lever/Inventory/ItemSetting")]
    public class ItemSetting : SerializedScriptableObject
    {
        [NonSerialized, OdinSerialize] private Item item = new Item();

        public Item GetItem => (Item)item.Clone();
    }
}