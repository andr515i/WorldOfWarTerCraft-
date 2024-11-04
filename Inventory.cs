using System.Security.Cryptography;

class Inventory 
{
// Atributes 
    private Item[] Items;
// Constructor 
public Inventory (Item[] Items) 
{
    this.Items = Items;
}

// Inventory display
public void InventoryDisplay() {
    Console.WriteLine("Inventory:"); 
    for (int i = 0 ; i< Items.Length ; i++ )
    {
 //Makes sure it only prints Item in inventory if there are any.
            if (Items[i]!= null) {
           
            Console.WriteLine(Items[i]);
            }
        
    }
} 
// Method for adding Items to inventory
public void AddItem (Item NewItem) 
{
    for (int i = 0 ; i< Items.Length;i++)
    {
        
            // Checks if there is place for a new item
            if(Items[i]==null)
            {
                Items[i] = (Item)NewItem;
                break; 
            }
        
    }
}
    

 }



