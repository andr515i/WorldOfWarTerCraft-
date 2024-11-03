class Inventory 
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