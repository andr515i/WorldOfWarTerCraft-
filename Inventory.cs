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
