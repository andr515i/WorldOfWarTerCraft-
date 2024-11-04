using System.Security.Cryptography;

class Item {
    private string name; 
    private int effect; 
    private int keyNumber; 
    

public string itemDescription;

// Constructor
public Item (string name, int effect, int keyNumber)
{
    this.name = name; 
    this.effect = effect; 
    this.keyNumber = keyNumber; 

public string FirstCharToUpper(string str)
{
    if (str == null)
        return null;

    if (str.Length > 1)
        return char.ToUpper(str[0]) + str.Substring(1);

    return str.ToUpper();
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

    public override string ToString() 
    {
    return $"{GetName().FirstCharToUpper} '\t' {GetEffect()} '\t' {GetDescription()}";
    }

    
}
