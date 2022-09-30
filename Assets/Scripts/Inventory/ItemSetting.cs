using UnityEngine;

namespace Inventory
{
    [CreateAssetMenu(fileName = "ItemSetting", menuName = "Lever/Inventory/ItemSetting")]
    public class ItemSetting : ScriptableObject
    {
        [SerializeField] private Item item;
    }
}