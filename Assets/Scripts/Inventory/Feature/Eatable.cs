using Inventory.Interfaces;

namespace Inventory
{
    public class Eatable : ItemFeature, IUsable
    {
        public void Use()
        {
            throw new System.NotImplementedException();
        }
    }
}