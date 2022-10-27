using System.Collections.Generic;
using Lever.Scripts.Inventory;
using Lever.Scripts.Inventory.Interfaces;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Lever.Scripts.UI
{
    public class StorageView : SerializedMonoBehaviour
    {
        [SerializeField] private IKeepStorage storageKeeper;
        [SerializeField] private ItemView.ItemView itemPrefab;
        [SerializeField] private Transform rootContainer;

        private List<ItemView.ItemView> itemViews;
        private Storage storage;

        private void Awake()
        {
            itemViews = new List<ItemView.ItemView>();
            storage = storageKeeper.GetStorage;
            storage.OnItemListUpdated += UpdateItemList;
        }

        private void UpdateItemList(List<Item> items)
        {
            ClearItemList();
            foreach (var item in items)
            {
                var itemView = Instantiate(itemPrefab, rootContainer);
                itemView.Init(item);
                itemViews.Add(itemView);
            }
        }

        private void ClearItemList()
        {
            foreach (var itemView in itemViews)
            {
                Destroy(itemView.gameObject);
            }
            itemViews.Clear();
        }
    }
}