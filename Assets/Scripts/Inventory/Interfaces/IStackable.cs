namespace Inventory.Interfaces
{
    public interface IStackable
    {
        int StackCapacity { get; set; }
        int CurrentAmount { get; set; }
    }
}