class CommandInventory : BaseCommand, ICommand
{
    Item [] Items;
    public CommandInventory() {
        this.description = "Display the player's inventory";
    }
    public void Execute(Context context, string command, string[] parameters)
    {
Item[] Items = new Item[4];
  Inventory inventory = new Inventory (Items);
  inventory.AddItem(new Item ("plastik" , 2, 2));
  inventory.AddItem(new Item ("skraldepose" , 3, 4));
  inventory.AddItem(new Item ("tyggegummi" , 4, 2));
  inventory.AddItem(new Item ("fiskenet" , 5, 7));

        inventory.InventoryDisplay(); 
    }
}