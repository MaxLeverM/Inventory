using UnityEngine;

namespace Inventory
{
    public abstract class Item
    {
        private int id;
        private string title;
        private string description;
        private Sprite icon;
        private float weight;
        
        // private float quality;
        // public float Quality => quality;
    }
}