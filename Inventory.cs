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
public void InventoryDisplay (Item NewItem) {

        for (int i = 0 ; i< Items.GetLength(0) ; i++ )
        {
            for (int j = 0; j < Items.GetLength(1); j++)
            {
                Console.Write(Items[i , j]);
            }
        }
        Console.WriteLine();
}
}
    
// Method for addig items to inventory 
public void AddItem (Item NewItem) {

        for (int i = 0 ; i< Items.Length ; i++ )
        {
            if (Items[i]== null)
            {
                Items[i] = (Item) NewItem;
                break; 
            }
        } 
    }
}
