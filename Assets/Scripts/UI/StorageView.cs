using System;
using System.Collections.Generic;
using Lever;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UI;
using UnityEngine;

namespace Inventory
{
    public class StorageView : SerializedMonoBehaviour
    {
        [SerializeField] private IKeepStorage storageKeeper;
        [SerializeField] private ItemView itemPrefab;
        [SerializeField] private Transform rootContainer;

        private List<ItemView> itemViews;
        private Storage storage;

        private void Awake()
        {
            itemViews = new List<ItemView>();
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