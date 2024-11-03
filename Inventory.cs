/*class Inventory 
{
// Atributes 
    private Items[] Items;
// Constructor 
public Inventory (Items[] Items) 
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
   
// Method for removing items from inventory
public void RemoveItem (string ItemName) 
{
    for (int i = 0 ; i<Items.Length ; i++) 
    {
        if (Items[i] != null && Items[i].GetName() == ItemName)
        {
            Items[i]= null;
            break; 
        }
    }
}
*/

using System.Collections;
using System.Security.Cryptography;

class Inventory
{
    static void Main(string[] args)
    {
        ArrayList item = new ArrayList();

        item.Add(new Item("Plastic trash", 69, 1));
    }
}

class Item
{
    public string title;
    public int effect;
    public int keyNumber;
    public Item(string _title, int _effect, int _keyNumber)
    {
        this.title = _title;
        this.effect = _effect;
        this.keyNumber = _keyNumber;
    }
}
