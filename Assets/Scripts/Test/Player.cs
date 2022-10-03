using System;
using Inventory;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEngine;

namespace Lever.Test
{
    public class Player : SerializedMonoBehaviour, IKeepStorage // Only for development
    {
        [SerializeField] private Health health;
        [NonSerialized, OdinSerialize] private Storage storage = new Storage();

        public Storage GetStorage => storage;
    }
}