using System;
using System.Collections.Generic;
using UnityEngine;

namespace Inventory
{
    [Serializable]
    public abstract class Item
    {
        [SerializeField] private int id;
        [SerializeField] private string title;
        [SerializeField] private string description;
        [SerializeField] private Sprite icon;
        [SerializeField] private float weight;

        [SerializeField] private List<ItemFeature> features;
        // private float quality;
        // public float Quality => quality;
    }
}