using System;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEngine;

namespace Lever.Scripts.Inventory
{
    [CreateAssetMenu(fileName = "ItemSetting", menuName = "Lever/Inventory/ItemSetting")]
    public class ItemSetting : SerializedScriptableObject
    {
        [NonSerialized, OdinSerialize] private Item item = new Item();

        public Item GetItem => (Item)item.Clone();
    }
}