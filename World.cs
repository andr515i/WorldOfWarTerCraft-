/* World class for modeling the entire in-game world
 */

class World {
  Space marineBase ;
  
  public World () {
    Space marineBase    = new Space("Marine base");
    Space corridor = new Space("Corridor");
    Space seaCave     = new Space("Sea cave");
    Space pit      = new Space("Darkest Pit");
    Space outside  = new Space("Outside");
    
    marineBase.AddEdge("door", corridor);
    corridor.AddEdge("door", seaCave);
    seaCave.AddEdge("north", pit);
    seaCave.AddEdge("south", outside);
    pit.AddEdge("door", seaCave);
    outside.AddEdge("door", seaCave);
    
    this.marineBase = marineBase;
  }
  
  public Space GetMarineBase () {
    return marineBase;
  }
}
