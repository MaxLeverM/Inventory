﻿using System;
using Inventory;
using TMPro;
using UI.FeatureItemView;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ItemView : MonoBehaviour
    {
        [SerializeField] private Button button;
        [SerializeField] private Image itemIcon;
        [SerializeField] private Image bottomBar;
        [SerializeField] private TMP_Text leftUpperText;
        [SerializeField] private TMP_Text rightUpperText;
        [SerializeField] private TMP_Text leftBottomText;
        [SerializeField] private TMP_Text rightBottomText;
        [SerializeField] private FeatureItemViewContainer featureItemViewContainer;
        private Item item;
        public Image BottomBar => bottomBar;
        public TMP_Text LeftUpperText => leftUpperText;
        public TMP_Text RightUpperText => rightUpperText;
        public TMP_Text LeftBottomText => leftBottomText;
        public TMP_Text RightBottomText => rightBottomText;

        public void Init(Item initItem)
        {
            item = initItem;
            itemIcon.sprite = item.Icon;
            rightBottomText.text = item.Weight.ToString("0.0");
            
            leftUpperText.text = string.Empty;
            leftBottomText.text = string.Empty;
            rightUpperText.text = string.Empty;
            bottomBar.fillAmount = 0f;

            foreach (var featureItemView in featureItemViewContainer.FeatureItemViews)
            {
                featureItemView.Draw(this, item);
            }
        }
    }
}