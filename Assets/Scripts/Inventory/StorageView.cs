using Sirenix.OdinInspector;
using UnityEngine;

namespace Inventory
{
    public class StorageView : MonoBehaviour
    {
        [SerializeField] private Storage storage;
        [SerializeField] private ItemSetting itemSetting;
        
        [Button("Add 200 bread")]
        private void AddBread()
        {
            var bread = itemSetting.GetItem;
            var stackable = bread.GetFeature(typeof(Stackable)) as Stackable;
            stackable.CurrentAmount = 200;
            storage.AddItem(bread);
        }
    }
}