class CommandInventory : BaseCommand, ICommand
{
    Item [] Items;
    public CommandInventory() {
        this.description = "Display the player's inventory";
    }
    public void Execute(Context context, string command, string[] parameters)
    {
 Item[] Items = new Item[9];
  Inventory inventory = new Inventory (Items);

    inventory.InventoryDisplay(); 
    }
}