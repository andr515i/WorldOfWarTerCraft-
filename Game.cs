/* Main class for launching the game
 */

class Game {
  static World    world    = new World();
  static Context  context  = new Context(world.GetBeach());
  static ICommand fallback = new CommandUnknown();
  static Registry registry = new Registry(context, fallback);
  
  private static void InitRegistry () {
    ICommand cmdExit = new CommandExit();
    registry.Register("exit", cmdExit);
    registry.Register("quit", cmdExit);
    registry.Register("bye", cmdExit);
    registry.Register("go", new CommandGo());
    //registry.Register("talk", new CommandNPC());
    registry.Register("help", new CommandHelp(registry));
  }
  
  static void Main (string[] args) {

  Item[,] Items = new Item[2,9];
  Inventory inventory = new Inventory (Items);
  inventory.AddItem(new Item ("plastik" , 2, 2));
  inventory.AddItem(new Item ("plastik" , 2, 2));
  inventory.AddItem(new Item ("plastik" , 2, 2));
  inventory.AddItem(new Item ("plastik" , 2, 2));
  inventory.InventoryDisplay();

   Console.WriteLine("Welcome to the World of Watercraft!");
    InitRegistry();
    context.GetCurrent().Welcome();
    
    while (context.IsDone()==false) {
      Console.Write("> ");
      string? line = Console.ReadLine();
      // Converts input from user to lowercase:)
      line = line.ToLower();
      if (line!=null) registry.Dispatch(line);
    }
    Console.WriteLine("You died");
  }
}
