using System.Security.Cryptography;

class Inventory 
{
// Atributes 
    private Item[,] Items;
// Constructor 
public Inventory (Item[,] Items) 
{
    this.Items = Items;
}

// Inventory display
public void InventoryDisplay() {

    for (int i = 0 ; i< Items.GetLength(0) ; i++ )
    {
        for (int j = 0; j < Items.GetLength(1); j++) 
        {
            //Makes sure it only prints Item in inventory if there are any.
            if (Items[i,j]!= null) {
            Console.WriteLine(Items[i,j]);
            }
        }
    }
} 
// Method for adding Items to inventory
public void AddItem (Item NewItem) 
{
    for (int i = 0 ; i< Items.GetLength(0);i++)
    {
        for (int j = 0 ; j< Items.GetLength(1);j++)
        {
            // Checks if there is place for a new item
            if(Items[i,j]==null)
            {
                Items[i,j] = (Item)NewItem;
                break; 
            }
        }
    }
}
    

 }



