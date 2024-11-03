using System.Security.Cryptography;

class Item {
    private string name; 
    private int effect; 
    private int keyNumber; 
// Constructor
public string itemDescription = null;



public Item (string name, int effect, int keyNumber)
{
    this.name = name; 
    this.effect = effect; 
    this.keyNumber = keyNumber; 
    { 
    case 1:
        itemDescription = "asdasdaf";
        break;
    case 2:
        itemDescription = "asdasdaf";
        break;        
    case 3:
        itemDescription = "asdasdaf";
        break;
    case 4:
        itemDescription = "asdasdaf";
        break;
    case 5:
        itemDescription = "asdasdaf";
        break;
    case 6:
        itemDescription = "asdasdaf";
        break;
    case 7:
        itemDescription = "asdasdaf";
        break;
    case 8:
        itemDescription = "asdasdaf";
        break;
    case 9:
        itemDescription = "asdasdaf";
        break;
    }
}
// methods 
public string GetName() 
    {
    return name; 
    }

    public int GetEffect() 
    {
    return effect; 
    }

    public string GetDescription() 
    {
    switch (keyNumber)
    { 
    case 1:
        itemDescription = "1";
        break;
    case 2:
        itemDescription = "2";
        break;        
    case 3:
        itemDescription = "3";
        break;
    case 4:
        itemDescription = "4";
        break;
    case 5:
        itemDescription = "5";
        break;
    case 6:
        itemDescription = "6";
        break;
    case 7:
        itemDescription = "7";
        break;
    case 8:
        itemDescription = "8";
        break;
    case 9:
        itemDescription = "9";
        break;
    }
    return itemDescription; 
    }
}
