using Lever.Scripts.Inventory;
using Lever.Scripts.Inventory.Feature;
using Lever.Scripts.Inventory.Interfaces;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Lever.Scripts.Tests
{
    public class DebugTest : SerializedMonoBehaviour
    {
        [SerializeField] private IKeepStorage storageKeeper;
        
        [TitleGroup("Add item")]
        [SerializeField] private ItemSetting itemToAdd;
        [TitleGroup("Add item")]
        [SerializeField] private int amount = 1;

        private Storage playerStorage;

        private void Awake()
        {
            playerStorage = storageKeeper.GetStorage;
        }

        [TitleGroup("Add item")][Button("Add item")]
        private void AddItem()
        {
            var item = itemToAdd.GetItem;
            if (item.FeatureExist(typeof(Stackable)))
            {
                var stackable = item.GetFeature(typeof(Stackable)) as Stackable;
                stackable.CurrentAmount = amount;
            }
            playerStorage.AddItem(item);
        }
    }
}