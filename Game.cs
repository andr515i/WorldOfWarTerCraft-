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

    // Initializing the Iems array with some items.
Item [] Items = new Item[] 
{
new Item ("Nøgle"),
new Item ("HavNøgle"),
new Item ("DeepSeaNøgle"),
new Item ("Gummibåd")
};
    Console.WriteLine("Welcome to the World of Watercraft!");
    
   
    
    InitRegistry();
    context.GetCurrent().Welcome();
    
    while (context.IsDone()==false) {
      Console.Write("> ");
      string? line = Console.ReadLine();
      line = line.ToLower();
      if (line!=null) registry.Dispatch(line);
    }
    Console.WriteLine("You died");
  }
}
