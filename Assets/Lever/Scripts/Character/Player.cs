using System;
using Lever.Scripts.Inventory;
using Lever.Scripts.Inventory.Interfaces;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEngine;

namespace Lever.Scripts.Tests
{
    public class Player : SerializedMonoBehaviour, IKeepStorage // Only for tests
    {
        [SerializeField] private Health health;
        [NonSerialized, OdinSerialize] private Storage storage = new Storage();

        public Storage GetStorage => storage;
    }
}